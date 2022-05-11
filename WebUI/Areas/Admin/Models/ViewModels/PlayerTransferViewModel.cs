using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class PlayerTransferViewModel
    {
        public List<Team> Teams { get; set; }
        public int Num { get; set; }
        public List<Position> Positions { get; set; }

    }
}
