using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class TeamNewsViewModel
    {
        public TeamDto Team { get; set; }
        public List<TagDto> Tags { get; set; }
        public List<NewsDto> News { get; set; }
    }
}
