using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class LeagueStandingViewModel
    {
        public LeagueDto League { get; set; }
        public Group Group { get; set; }
        public List<TeamStandingsViewModel> Teams { get; set; }
    }
}
