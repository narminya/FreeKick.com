using Domain.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class PlayerCreateViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public int PositionId { get; set; }
        public List<Position> Position { get; set; }
        public IFormFile Picture { get; set; }
        public int TagId { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
