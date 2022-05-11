using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedUserId { get; set; }
        public string InstaPost { get; set; }
        public int ViewCount { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<NewsTag> Tags { get; set; }
    }
}
