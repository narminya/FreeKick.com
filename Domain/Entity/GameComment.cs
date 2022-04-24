using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class GameComment
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
