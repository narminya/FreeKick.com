using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class MatchViewModel
    {
        public int MatchId { get; set; }
        public string HomeImage { get; set; }
        public string HomeName { get; set; }
        public int HomeTeamScore { get; set; }
        public string HomeCoach { get; set; }
        public string AwayImage { get; set; }
        public string AwayName { get; set; }
        public int AwayTeamScore { get; set; }
        public string AwayCoach { get; set; }
        public DateTime Date { get; set; }
    }
}
