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
                League = new LeagueDto() { LeagueId = league.Id, LeagueIcon = league.Logo, LeagueName = league.Name, LeagueTitle = league.TitleImage },
                Teams = _context.TeamLeague.Where(c => c.LeagueId == id)
                .Select(m => new TeamStandingsViewModel { Id=m.TeamId, Name = m.Team.Name, Points = m.Points, Logo = m.Team.Logo }).OrderByDescending(m => m.Points).ToList()
            };

            return View(result);
        }
        public async Task<IActionResult> LeagueMatches(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var league = await _context.League.FindAsync(id);
            var result = new LeagueMatchesViewModel()
            {

                League = new LeagueDto() { LeagueId = league.Id, LeagueIcon = league.Logo, LeagueName = league.Name, LeagueTitle = league.TitleImage },
                Matches = _context.Games.Include(v => v.Teams).Where(c => c.LeagueId == id)
                  .Select(c => new MatchViewModel
                  { MatchId=c.Id,
                      Away = new GameTeamDto
                      {
                          TeamName = c.Teams.AwayTeam.Name,
                          TeamScore = c.AwayScore,
                      },
                      Home = new GameTeamDto
                      {
                          TeamName = c.Teams.HomeTeam.Name,
                          TeamScore = c.HomeScore,
                      }
                  }).Take(4).ToList()
            };

            return View(result);
        }

        

        public PartialViewResult LeaguePartial(LeagueDto league)
        {
            return PartialView("_LeaguePartial", league);
        }


        public PartialViewResult LoadMoreMatches(int skipCount, int id)
        {
            var result = _context.Games.Include(v => v.Teams).Where(c => c.LeagueId == id)
                  .Select(c => new MatchViewModel
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
                      }
                  }).Skip(skipCount).Take(4).ToList();
            return PartialView("_MatchPartial", result);
        }
    }
}
