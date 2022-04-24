using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<NewsTag> NewsTags { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
