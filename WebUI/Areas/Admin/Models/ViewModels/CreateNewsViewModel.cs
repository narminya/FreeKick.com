using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class CreateNewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string InstaPost { get; set; }
        public string Image { get; set; }
        public List<Tag> Tags { get; set; }
        public int[] Tagsx { get; set; }
        public IFormFile File { get; set; }
    }
}
