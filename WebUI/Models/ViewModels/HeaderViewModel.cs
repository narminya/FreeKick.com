using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class HeaderViewModel
    {
        public List<Navigation> Parents { get; set; }
        public List<Navigation> Children { get; set; }
    }
}
