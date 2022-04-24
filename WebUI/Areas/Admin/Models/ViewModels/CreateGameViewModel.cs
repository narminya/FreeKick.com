using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class CreateGameViewModel
    {
        public List<Team> Teams { get; set; }
        public List<League> Leagues { get; set; }
        [Required]
        public int LeagueId { get; set; }
        public List<Season> Seasons { get; set; }
        [Required]
        public int SeasonId { get; set; }
        [Required]
        public int HomeId { get; set; }
        [Required]
        public int AwayId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
    }
}
