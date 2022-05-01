using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{

    public class GameResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public char Letter { get; set; }
    }
}
