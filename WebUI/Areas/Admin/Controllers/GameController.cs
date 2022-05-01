using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models.ViewModels;
using WebUI.Models.ViewModels;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController : Controller
    {
        private readonly AppDbContext _context;
        public GameController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.League.Include(c => c.Teams)
                 .Select(r => new LiveMatchesViewModel
                 {
                     League = new LeagueDto() { LeagueId = r.Id, LeagueIcon = r.TitleImage, LeagueName = r.Name },
                     Matches = r.Games.Select(c => new MatchViewModel
                     {
                         Away = new GameTeamDto
                         {
                             TeamName = c.Teams.AwayTeam.Name,
                             TeamScore = c.AwayScore,
                         },
                         Home = new GameTeamDto
                         {
                             TeamName = c.Teams.HomeTeam.Name,
                             TeamScore = c.HomeScore,
                         },
                         Date = c.Teams.Game.Date
                     }).OrderByDescending(c => c.Date).ToList()
                 }).ToList();


            return View(result);
        }
        public IActionResult Create()
        {
            var cv = new CreateGameViewModel()
            {
                Teams = _context.Teams.ToList(),
                Leagues = _context.League.ToList(),
                Seasons = _context.Seasons.ToList()

            };
            return View(cv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameViewModel cv)
        {
            cv.Teams = _context.Teams.ToList();
            cv.Leagues = _context.League.ToList();
            cv.Seasons = _context.Seasons.ToList();
            if (!ModelState.IsValid)
            {
                return View(cv);
            }

            var game = new Game()
            {
                LeagueId = cv.LeagueId,
                SeasonId = cv.SeasonId,
                Date = new DateTime(cv.Date.Year, cv.Date.Month, cv.Date.Day, cv.Time.Hour, cv.Time.Minute, cv.Time.Second)
            };

            game.Teams = new GameTeam()
            {
                AwayTeamId = cv.AwayId,
                HomeTeamId = cv.HomeId
            };


            await _context.AddAsync(game);
            await _context.SaveChangesAsync();

            return View("Index","Dashboard");
        }
        public IActionResult GameLineUp(int? id)
        {
            ViewBag.Id = id;
            var game = _context.GamesTeam.Where(c => c.GameId == id);
            var res = new GameLineUpViewModel()
            {
                AwayPlayers = _context.TeamPlayer.Where(c => c.TeamId == game.FirstOrDefault().AwayTeamId).Select(b => new PlayerDto { Id = b.Id, Num = b.Num, Surname = b.Player.Surname }).ToList(),
                HomePlayers = _context.TeamPlayer.Where(c => c.TeamId == game.FirstOrDefault().HomeTeamId).Select(b => new PlayerDto { Id = b.Id, Num = b.Num, Surname = b.Player.Surname }).ToList(),
                Positions = _context.GamePositions.ToList(),
            
            };
            return View(res);
        }
        public async Task<IActionResult> PlayerPosition(GameLineup player)
        {
            var play = new PlayerViewModel()
            {
                Surname = _context.TeamPlayer.Include(c=>c.Player).Where(c => c.Id == player.TeamPlayerId)
                .Select(c => new {surname= c.Player.Surname }).FirstOrDefault().surname,
                Position = _context.GamePositions.Find(player.GamePositionId).Name,
                Id = player.GameId
            };

           var current = _context.GameLineup.Where(c=>c.TeamPlayerId==player.TeamPlayerId).FirstOrDefault();
            if (current != null)
            {
                return Json(new { message = "Already in lineup" });
            }
            await _context.AddAsync(player);
            await _context.SaveChangesAsync();
            return PartialView("_LineupPartial", play);
        }
        public JsonResult GetPlayers(int id, int? skip)
        {
            var result = _context.TeamPlayer.Where(c => c.TeamId == id && c.PlayerId==id)
                .Select(c => new PlayerDto { Surname = c.Player.Surname, Num = c.Num });
            return Json(result);
        }
        public JsonResult GetTeam(int id, int? skip)
        {
            var res = _context.TeamLeague.Where(c => c.LeagueId == id && c.TeamId != skip)
                .Select(b => new TeamDto { Id = b.TeamId, Name = b.Team.Name });
            return Json(res);
        }
    }
}
