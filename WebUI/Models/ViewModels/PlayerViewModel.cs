using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Num { get; set; }
        public string Position { get; set; }
        public string MainPosition { get; set; }
        public string Start { get; set; }
        public string Logo { get; set; }
        public bool IsChanged { get; set; }
        public List<Event> Event { get; set; }
    }
}
