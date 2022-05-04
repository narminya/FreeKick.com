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
                          MatchId = c.Id,
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

        public IActionResult Detail(int? id)
        {
            var game = _context.GamesTeam.Where(c => c.GameId == id);
            if (game==null)
            {
                return NotFound();
            }

            ViewBag.Id = id;
            var model = _context.GamesTeam.Where(c => c.GameId == id);
            var res = new GameLineUpViewModel()
            {
                  Match = game.Select(f => new MatchViewModel
                  {
                      Away = new GameTeamDto
                      {
                          TeamId = f.AwayTeam.Id,
                          TeamName = f.AwayTeam.Name,
                          TeamImage = f.AwayTeam.Logo,
                          TeamScore = f.Game.AwayScore,
                          TeamCoach = f.AwayTeam.Coach
                      },
                      Home = new GameTeamDto
                      {
                          TeamId = f.HomeTeam.Id,
                          TeamName = f.HomeTeam.Name,
                          TeamImage = f.HomeTeam.Logo,
                          TeamScore = f.Game.HomeScore,
                          TeamCoach = f.HomeTeam.Coach
                      },
                      Date = f.Game.Date,
                      MatchId = f.Game.Id
                  }).FirstOrDefault(),
                AwayLineUp = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().AwayTeamId)
                .Select(b => new PlayerViewModel { Id = b.Id, Surname = b.TeamPlayer.Player.Surname, Position = b.GamePosition.Name, IsChanged=b.IsChanged }).ToList(),

                HomeLineUp = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().HomeTeamId)
                .Select(b => new PlayerViewModel { Id = b.Id, Surname = b.TeamPlayer.Player.Surname, Position = b.GamePosition.Name, IsChanged=b.IsChanged}).ToList(),

                AwayPlayers = _context.TeamPlayer.Where(c => c.TeamId == game.FirstOrDefault().AwayTeamId).Select(b => new PlayerDto { Id = b.Id, Num = b.Num, Surname = b.Player.Surname }).ToList(),

                HomePlayers = _context.TeamPlayer.Where(c => c.TeamId == game.FirstOrDefault().HomeTeamId).Select(b => new PlayerDto { Id = b.Id, Num = b.Num, Surname = b.Player.Surname }).ToList(),
                Positions = _context.GamePositions.ToList(),
                Status = _context.Status.ToList()

            };
            return View(res);
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

            return RedirectToAction("Index", "Match", new { area = "",Id=game.Id });
        }  
        public async Task<IActionResult> PlayerPosition(GameLineup player)
        {
            var play = new PlayerViewModel()
            {
                Surname = _context.TeamPlayer.Include(c => c.Player).Where(c => c.Id == player.TeamPlayerId)
                .Select(c => new { surname = c.Player.Surname }).FirstOrDefault().surname,
                Position = _context.GamePositions.Find(player.GamePositionId).Name,
                Start = _context.Status.Find(player.StatusId).Name
            };

            var current = _context.GameLineup.Where(c => c.TeamPlayerId == player.TeamPlayerId).FirstOrDefault();
            if (current != null)
            {
                return Json(new { message = "Already in lineup" });
            }
            await _context.AddAsync(player);
            await _context.SaveChangesAsync();
            play.Id = player.Id;
            return PartialView("_LineupPartial", play);
        }

        public async Task<IActionResult> Goal(GameScore score)
        {
            var gameteam =_context.GamesTeam.Include(c=>c.Game).Where(c => c.GameId == score.GameId).FirstOrDefault();
            if (gameteam == null)
            {
                return NotFound();
            }

            var team = _context.TeamPlayer.Where(s => s.PlayerId == score.PlayerId).FirstOrDefault().TeamId;
            var game = _context.Games.Find(score.GameId);
            if (gameteam.HomeTeamId == team && score.OwnGoal==true)
            {
                game.AwayScore++;
            }
            else if(gameteam.AwayTeamId == team && score.OwnGoal == true)
            {
               game.HomeScore++;
            }
            else if(gameteam.HomeTeamId == team && score.OwnGoal == false)
            {
                game.HomeScore++;
            }
            else
            {
                game.AwayScore++;
            }

            _context.Update(gameteam);
            await _context.GameScores.AddAsync(score);
            await _context.SaveChangesAsync();
            return Json(new { minute= score.Minute, authorId=score.PlayerId});
           
        }
        public JsonResult GetTeam(int id, int? skip)
        {
            var res = _context.TeamLeague.Where(c => c.LeagueId == id && c.TeamId != skip)
                .Select(b => new TeamDto { Id = b.TeamId, Name = b.Team.Name });
            return Json(res);
        }
       
        public IActionResult ChangePlayer(int id)
        {
            var gamePlayer = _context.GameLineup.Where(c => c.Id == id).FirstOrDefault();
         
            gamePlayer.IsChanged = true;
            _context.GameLineup.Update(gamePlayer);
            _context.SaveChanges();
            return Json(new { status= "Replaced"});
        }
        [HttpPost]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var line = _context.GameLineup.Find(id);
          
            _context.GameLineup.Remove(line);
           await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
