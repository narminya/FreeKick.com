using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GamePlayerEvent
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int GamePlayerId { get; set; }
        public GameLineup GamePlayer { get; set; }
        public string Minute { get; set; }
    }
}
