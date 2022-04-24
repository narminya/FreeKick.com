using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class HomeViewModel
    {
        public NewsViewModel Breaking { get; set; }
        public List<NewsViewModel> News { get; set; }
        public List<NewsViewModel> Latest { get; set; }

    }
}
