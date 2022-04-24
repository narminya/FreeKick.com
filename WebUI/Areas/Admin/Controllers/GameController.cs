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
                     Matches = r.Games.Select(n => new MatchViewModel
                     {
                         AwayName = n.Teams.AwayTeam.Name,
                         AwayTeamScore = n.Teams.Game.AwayScore,
                         HomeName = n.Teams.HomeTeam.Name,
                         HomeTeamScore = n.Teams.Game.HomeScore,
                         Date = n.Teams.Game.Date
                     }).OrderByDescending(c=>c.Date).ToList()
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

            return View(game);
        }

        public JsonResult GetTeam(int id,int? skip)
        {
            var res = _context.TeamLeague.Where(c => c.LeagueId == id && c.TeamId!=skip )
                .Select(b => new TeamDto { Id = b.TeamId, Name = b.Team.Name });
            return Json(res);
        }
    }
}
