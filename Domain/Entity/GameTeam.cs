using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class GameTeam : IEntity
    {
        public int Id { get; set; }
        [ForeignKey("Team")]
        public int? HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public string HomePattern { get; set; }
        [ForeignKey("Team")]
        public int? AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public string AwayPattern { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
