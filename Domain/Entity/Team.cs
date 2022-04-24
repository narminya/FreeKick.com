using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string TitleImage { get; set; }
        public string Stadium { get; set; }
        public string Coach { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<TeamLeague> TeamLeague { get; set; }
        public ICollection<Game> Games { get; set; }



    }
}
