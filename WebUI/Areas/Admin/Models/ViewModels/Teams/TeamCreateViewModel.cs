using Domain.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels.Teams
{
    public class TeamCreateViewModel
    {
        public string Name { get; set; }
        public string Stadium { get; set; }
        public string Coach { get; set; }
        public int CountryId { get; set; }
        public int TagId { get; set; }

        public List<Country> Countries { get; set; }
        public List<Tag> Tags { get; set; }
        public IFormFile Logo { get; set; }
        public IFormFile Title { get; set; }


    }
}
