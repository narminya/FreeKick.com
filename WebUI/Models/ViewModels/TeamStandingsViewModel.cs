using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class TeamStandingsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public int Standings { get; set; }
        public int Points { get; set; }
    }
}
