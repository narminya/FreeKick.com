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
        private readonly IMapper _mapper;
        public TeamController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            var result = new TeamNewsViewModel() {
               Team = new TeamDto { Id = team.Id, Logo = team.Logo, Name = team.Name },
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
            if (team==null)
            {
                return NotFound();
            }
            var res = new TeamsMatchesViewModel()
            {
                Team = new TeamDto() {  Id = team.Id, Name = team.Name, Logo=team.Logo},
                Matches = await _context.GamesTeam.Where(h => h.HomeTeamId == id || h.AwayTeamId == id)
                 .Select(c => new MatchViewModel
                 {
                     HomeName = c.HomeTeam.Name,
                     AwayName = c.AwayTeam.Name,
                     AwayTeamScore = c.Game.AwayScore,
                     HomeTeamScore = c.Game.HomeScore
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


            return View(new TeamInfoViewModel {  Team = new TeamDto { } } );
        }

      
    }
}
