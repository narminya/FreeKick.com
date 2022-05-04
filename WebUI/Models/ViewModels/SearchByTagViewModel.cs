using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class SearchByTagViewModel
    {
        public List<NewsDto> News { get; set; }
        public Player Player { get; set; }
        public OuterLeague OuterLeague { get; set; }
        public League League { get; set; }
        public Team Team { get; set; }

    }
}
