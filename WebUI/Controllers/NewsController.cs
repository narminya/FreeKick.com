using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (!id.HasValue || id.Value == 0)
            {
                return BadRequest();
            }
          
            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            var model = new NewsViewModel()
            {
                News = news,
                Tags = await _context.NewsTag.Where(t => t.NewsId == news.Id).Select(x =>
                new Tag
                {
                    Name = x.Tag.Name
                }).ToListAsync(),
                Time = news.CreatedDate.ToRelativeDate()
            };

            return View(model);
        }


    }
}
