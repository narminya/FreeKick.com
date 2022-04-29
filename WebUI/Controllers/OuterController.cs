using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class OuterController : Controller
    {
        private readonly AppDbContext _context;
        public OuterController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }

            var league = _context.Groups.Where(c=>c.OuterLeagueId==id)
                   .Select(r => new LeagueStandingViewModel
                   {
                        League = new LeagueDto { LeagueIcon = r.OuterLeague.Logo, LeagueName = r.OuterLeague.Name, LeagueId = r.OuterLeague.Id},
                       Group = new Group() { OuterLeagueId = r.OuterLeagueId, Letter = r.Letter },
                       Teams = r.Teams
                          .Select(m => new TeamStandingsViewModel { Id= m.Team.Id, Name = m.Team.Name, Points = m.Points, Logo = m.Team.Logo }).OrderByDescending(b => b.Points)
                          .ToList()
                   }).OrderBy(c=>c.Group.Letter).ToList();

            return View(league);
        }
    }
}
