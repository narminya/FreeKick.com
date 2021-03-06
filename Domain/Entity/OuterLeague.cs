using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class OuterLeague
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Title { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
