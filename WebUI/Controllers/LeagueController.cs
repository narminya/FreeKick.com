using Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class LeagueController : Controller
    {
        private readonly AppDbContext _context;
        public LeagueController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var league = await _context.League.FindAsync(id);
            var result = new LeagueStandingViewModel()
            {
                League = new LeagueDto() { LeagueId = league.Id, LeagueIcon = league.Logo, LeagueName = league.Name },
                Teams =  _context.TeamLeague.Where(c => c.LeagueId == id)
                .Select(m => new TeamStandingsViewModel {  Name = m.Team.Name,  Points = m.Points, Logo= m.Team.Logo }).OrderByDescending(m=>m.Points).ToList()
            };
                
            return View(result);
        }
        public IActionResult LeagueMatches(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }

            var result = _context.Games.Include(v=>v.Teams).Where(c => c.LeagueId == id)
                  .Select(c => new MatchViewModel
                  {
                      HomeName = c.Teams.HomeTeam.Name,
                      AwayName = c.Teams.AwayTeam.Name,
                      AwayTeamScore = c.AwayScore,
                      HomeTeamScore = c.HomeScore
                  }).Take(4).ToList();

            return View(result);
        }

        public async Task<IActionResult> LeagueStanding(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var result =await _context.TeamLeague.Where(l => l.LeagueId == id)
                .Select(c => new TeamStandingsViewModel { Id = c.TeamId, Logo = c.Team.Logo, Name = c.Team.Name, Points = c.Points }).OrderByDescending(c => c.Points).ToListAsync();
                

            return View(result);
        }

        public PartialViewResult LoadMoreMatches(int skipCount, int id)
        {
            var result = _context.Games.Include(v => v.Teams).Where(c => c.LeagueId == id)
                  .Select(c => new MatchViewModel
                  {
                      HomeName = c.Teams.HomeTeam.Name,
                      AwayName = c.Teams.AwayTeam.Name,
                      AwayTeamScore = c.AwayScore,
                      HomeTeamScore = c.HomeScore
                  }).Skip(skipCount).Take(4).ToList();


            return PartialView("_MatchPartial", result);
        }
    }
}
