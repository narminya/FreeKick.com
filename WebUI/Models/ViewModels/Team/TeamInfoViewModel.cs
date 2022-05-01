using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class SquadViewModel
    {
        public List<PlayerDto> Players { get; set; }
        public Position Position { get; set; }
    }
}
