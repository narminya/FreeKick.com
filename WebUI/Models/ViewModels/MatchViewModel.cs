using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class MatchViewModel
    {
        public GameTeamDto Away { get; set; }
        public List<GoalDto> AwayGoals { get; set; }
        public GameTeamDto Home { get; set; }
        public List<GoalDto> HomeGoals { get; set; }
        public DateTime Date { get; set; }
        public int MatchId { get; set; }

    }
}
