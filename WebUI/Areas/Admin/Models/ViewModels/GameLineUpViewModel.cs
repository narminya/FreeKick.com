using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class GameLineUpViewModel
    {
        public List<PlayerDto> HomePlayers { get; set; }
        public List<PlayerViewModel> HomeLineUp { get; set; }
        public MatchViewModel Match { get; set; }
        public List<GamePosition> Positions { get; set; }
        public List<PlayerDto> AwayPlayers { get; set; }
        public List<PlayerViewModel> AwayLineUp { get; set; }
        public List<Status> Status { get; set; }
        public List<Event> Events { get; set; }
    }
}
