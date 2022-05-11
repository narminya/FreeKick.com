using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class PlayerController : Controller
    {
        private readonly AppDbContext _context;
        public PlayerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
            var team = await _context.Player.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }



            return View();
        }
    }
}
