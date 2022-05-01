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

namespace WebUI.Models.ViewComponents
{
    public class StandingsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public StandingsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var result = _context.League.Include(c => c.Teams)
                  .Select(r => new LeagueStandingViewModel
                  {
                      League = new LeagueDto() { LeagueId = r.Id, LeagueIcon=r.Logo, LeagueName = r.Name},
                      Teams = r.Teams
                          .Select(m => new TeamStandingsViewModel {  Id = m.Team.Id,Name = m.Team.Name, Points = m.Points, Logo = m.Team.Logo }).OrderByDescending(b => b.Points)
                          .ToList()
                  }).ToList();


            return View(result);
        }
    }
}
