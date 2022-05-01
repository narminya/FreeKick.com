using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Position : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? CreatedUserId { get; set; }
        public ICollection<TeamPlayer> Players { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
