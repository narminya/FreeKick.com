using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class GameLineUpViewModel
    {
        public List<PlayerDto> HomePlayers { get; set; }
        public List<GamePosition> Positions { get; set; }
        public List<PlayerDto> AwayPlayers { get; set; }

    }
}
