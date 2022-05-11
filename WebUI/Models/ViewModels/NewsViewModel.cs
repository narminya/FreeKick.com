using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class NewsViewModel
    {
        public News News { get; set; }
        public List<Tag> Tags { get; set; }
        public string Time { get; set; }
        public string InstaPost { get; set; }
        
    }
}
