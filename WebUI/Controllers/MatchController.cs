using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Hubs;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class MatchController : Controller
    {
        private readonly AppDbContext _context;
        private IBroadcastRepository _repo;
        public MatchController(AppDbContext context, IBroadcastRepository repo)
        {
            _context = context;
            _repo = repo;
        }
        public IActionResult Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            ViewData["Id"] = id;
            var game = _context.GamesTeam.Where(c => c.GameId == id);
            var match = new MatchStatsViewModel()
            {
                Match = game
                .Select(f => new MatchViewModel
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

                HomeLineups = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().HomeTeamId)
                .Select(n => new PlayerViewModel
                {
                    Surname = n.TeamPlayer.Player.Surname,
                    Num = n.TeamPlayer.Num,
                    Position = n.GamePosition.ShortName,
                    MainPosition = n.GamePosition.CommonName
                })
                .ToList(),

                AwayLineups = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().AwayTeamId)
                .Select(n => new PlayerViewModel
                {
                    Surname = n.TeamPlayer.Player.Surname,
                    Num = n.TeamPlayer.Num,
                    Position = n.GamePosition.ShortName,
                    MainPosition = n.GamePosition.CommonName
                })
                .ToList(),
                Comments = _context.GameComments.Where(C => C.GameId == id)
                 .Select(c => new Comment { Message = c.Comment.Message, Minute = c.Comment.Minute })
                 .ToList()
            };
            return View(match);
        }

        public IActionResult LiveScores()
        {
            var result = _context.League.Include(c => c.Teams)
                .Select(r => new LiveMatchesViewModel
                {
                    League = new LeagueDto() { LeagueId = r.Id, LeagueIcon = r.TitleImage, LeagueName = r.Name },
                    Matches = r.Games.Where(c => c.Date.Day == DateTime.Now.Day).Select(n => new MatchViewModel
                    {
                        Away = new GameTeamDto { TeamName = n.Teams.AwayTeam.Name,  TeamImage = n.Teams.AwayTeam.Logo, TeamScore = n.Teams.Game.AwayScore },
                        Home = new GameTeamDto { TeamName = n.Teams.HomeTeam.Name, TeamImage = n.Teams.HomeTeam.Logo, TeamScore = n.Teams.Game.HomeScore },
                        Date = n.Teams.Game.Date
                    }).OrderBy(c => c.Date).ToList()
                }).ToList();
            return View(result);
        }


        public async Task<IActionResult> SendMessage(
           int gameId,
           string minute,
           string message,
           [FromServices] IHubContext<BroadcastHub> chat)
        {
            var comment = await _repo.CreateMessage(message, minute, gameId);

            await chat.Clients.Group(gameId.ToString())
                .SendAsync("RecieveMessage", new
                {
                    message = comment.Message,
                    minute = comment.Minute
                });

            return Ok();
        }
    }
}
