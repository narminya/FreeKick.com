using AutoMapper;
using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            var news = await _context.NewsTag.Where(c => c.TagId == team.TagId)
                .Select(n => new NewsDto { Id = n.Id, Title = n.News.Title, Description = n.News.Description }).ToListAsync();
            var result = new TeamNewsViewModel()
            {
                Team = new TeamDto { Id = team.Id, Logo = team.Logo, Name = team.Name, TitleImage=team.TitleImage },
                News = news
            };

            return View(result);
        }

        public async Task<IActionResult> TeamMatches(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }

            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }
            var res = new TeamsMatchesViewModel()
            {
                Team = new TeamDto() { Id = team.Id, Name = team.Name, Logo = team.Logo, TitleImage = team.TitleImage },
                Matches = await _context.GamesTeam.Where(h => h.HomeTeamId == id || h.AwayTeamId == id)
                 .Select(c => new MatchViewModel
                 {
                     Away = new GameTeamDto
                     {
                         TeamName = c.AwayTeam.Name,
                         TeamScore=  c.Game.AwayScore,

                     },
                     Home = new GameTeamDto
                     {
                         TeamName = c.HomeTeam.Name,
                         TeamScore = c.Game.HomeScore,
                     }
                 }).ToListAsync()
            };
            return View(res);
        }

        public async Task<IActionResult> TeamInfo(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            var result = new TeamInfoViewModel()
            {
                Team = new TeamDto { Id = team.Id, Logo = team.Logo, Name = team.Name, TitleImage = team.TitleImage },
                Squad = _context.Positions.Select(c => new SquadViewModel
                {
                    Position = new Position { Id = c.Id, Name = c.Name },
                    Players = c.Players.Where(c=>c.TeamId==team.Id).Select(n => new PlayerDto { Id = n.Id, Name = n.Player.Name, Num = n.Num, Surname = n.Player.Surname }).ToList()
                }).ToList()
            };


            return View(result);
        }

        public PartialViewResult TeamActions(TeamDto team)
        {

            return PartialView("_TeamPartial", team);
        }
    }
}
