using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class PlayerViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Num { get; set; }
        public string Position { get; set; }
        public bool Start { get; set; }
        public string Logo { get; set; }
    }
}
