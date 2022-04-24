using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewComponents
{
    public class ActionsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ActionsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
