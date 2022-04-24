using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class OuterController : Controller
    {
        private readonly AppDbContext _context;
        public OuterController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
