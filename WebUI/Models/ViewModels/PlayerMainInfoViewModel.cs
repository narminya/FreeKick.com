using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class PlayerMainInfoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Num { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public string Country { get; set; }
    }
}
