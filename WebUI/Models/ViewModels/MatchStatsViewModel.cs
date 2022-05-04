using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class MatchStatsViewModel
    {
        public MatchViewModel Match { get; set; }
        public List<PlayerViewModel> HomeLineups { get; set; }

        public List<PlayerViewModel> AwayLineups { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
