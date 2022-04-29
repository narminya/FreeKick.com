using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class TeamsMatchesViewModel
    {
        public TeamDto Team { get; set; }
        public List<MatchViewModel> Matches { get; set; }
    }
}
