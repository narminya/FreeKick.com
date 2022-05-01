using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
   public class GameTeamDto
    {
        public int TeamId { get; set; }
        public string TeamImage { get; set; }
        public string TeamName { get; set; }
        public int TeamScore { get; set; }
        public string TeamCoach { get; set; }
    }
}
