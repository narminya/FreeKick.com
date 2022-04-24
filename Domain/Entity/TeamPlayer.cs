using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public int? PlayerId { get; set; }
        public Player Player { get; set; }
        public int Num { get; set; }
    }
}
