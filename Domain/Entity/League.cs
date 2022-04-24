using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class League : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string TitleImage { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual ICollection<TeamLeague> Teams { get; set; }
        public virtual ICollection<Game> Games { get; set; }

    }
}
