using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class GameLineup : IEntity
    {
        public int Id { get; set; }
        public int TeamPlayerId { get; set; }
        public TeamPlayer TeamPlayer { get; set; }
        public int GamePositionId { get; set; }
        public GamePosition GamePosition { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
