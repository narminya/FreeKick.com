using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;

namespace WebUI.Models.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var header = new HeaderViewModel()
            {
                Parents = _context.Navigation.Where(c=>c.ParentId==null).OrderBy(c => c.Order).ToList(),
                Children = _context.Navigation.Where(c => c.ParentId != null).OrderBy(c => c.Order).ToList(),
            };
            return View(header);
        }
    }
}
