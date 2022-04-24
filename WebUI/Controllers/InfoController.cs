using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class InfoController : Controller
    {
        private readonly AppDbContext _context;
        public InfoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
