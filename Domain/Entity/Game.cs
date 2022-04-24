using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int? LeagueId { get; set; }
        public League League { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public DateTime Date { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public bool IsFinished { get; set; }
        public ICollection<GameScore> Goals { get; set; }
        public ICollection<GameLineup> Lineups { get; set; }
        public ICollection<GameComment> Comments { get; set; }
        public GameTeam Teams { get; set; }

    }
}
