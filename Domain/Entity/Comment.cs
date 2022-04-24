using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Minute { get; set; }
        public ICollection<GameComment> GameComments { get; set; }
    }
}
