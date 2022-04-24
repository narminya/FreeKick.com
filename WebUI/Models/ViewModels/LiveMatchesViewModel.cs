using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class LiveMatchesViewModel
    {
        public LeagueDto League { get; set; }
        public List<MatchViewModel> Matches { get; set; }

    }
}
