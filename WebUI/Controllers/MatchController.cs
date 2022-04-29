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
                    AwayImage = f.AwayTeam.Logo,
                    AwayName = f.AwayTeam.Name,
                    AwayTeamScore = f.Game.AwayScore,
                    Date = f.Game.Date,
                    HomeImage = f.HomeTeam.Logo,
                    HomeName = f.HomeTeam.Name,
                    HomeTeamScore = f.Game.HomeScore,
                    AwayCoach = f.AwayTeam.Coach,
                    HomeCoach = f.HomeTeam.Coach
                }).FirstOrDefault(),

                HomeLineups = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().HomeTeamId)
                .Select(n => new PlayerViewModel
                {
                    Surname = n.TeamPlayer.Player.Surname,
                    Num = n.TeamPlayer.Num,
                    Start = n.Start,
                    Position = n.GamePosition.Name,
                    MainPosition = n.GamePosition.CommonName
                })
                .ToList(),

                AwayLineups = _context.GameLineup.Where(c => c.GameId == id && c.TeamPlayer.TeamId == game.FirstOrDefault().AwayTeamId)
                .Select(n => new PlayerViewModel
                {
                    Surname = n.TeamPlayer.Player.Surname,
                    Num = n.TeamPlayer.Num,
                    Start = n.Start,
                    Position = n.GamePosition.Name,
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
                        AwayName = n.Teams.AwayTeam.Name,
                        AwayTeamScore = n.Teams.Game.AwayScore,
                        HomeName = n.Teams.HomeTeam.Name,
                        HomeTeamScore = n.Teams.Game.HomeScore,
                        Date = n.Teams.Game.Date
                    }).ToList()
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
