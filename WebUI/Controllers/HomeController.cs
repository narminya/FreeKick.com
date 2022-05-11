using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;
using WebUI.Utilities;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var breaking = await _context.News.Include(t => t.Tags).OrderByDescending(c => c.CreatedDate).FirstOrDefaultAsync();
            var tags = await _context.NewsTag.Where(t => t.NewsId == breaking.Id).Select(x =>
            new Tag
            {
                Name = x.Tag.Name
            }).ToListAsync();
            var nesw = new List<NewsViewModel>();
            var news = await _context.News.Include(c=>c.Tags).Where(c => c.Id != breaking.Id).OrderByDescending(c => c.CreatedDate).Take(2).ToListAsync();
            foreach (var item in news)
            {
                nesw.Add(new NewsViewModel
                {
                    News = item,
                    Tags = await _context.NewsTag.Where(t => t.NewsId == item.Id).Select(x =>
                    new Tag
                    {
                        Id = x.TagId,
                        Name = x.Tag.Name
                    }).ToListAsync()
                });
            }
            var latest = await _context.News.Include(c=>c.Tags).OrderByDescending(c => c.CreatedDate).Skip(3)
                .Take(10).Select(s => new NewsViewModel { News = s, Time = s.CreatedDate.ToRelativeDate(),  Tags=s.Tags.Select(c=>new Tag { Name = c.Tag.Name, Id = c.TagId }).ToList() }).ToListAsync();
            return View(new HomeViewModel
            {
                News = nesw,
                Breaking = new NewsViewModel
                {
                    Tags = tags,
                    News = breaking,
                },
                Latest = latest
            });
        }

        public async Task<IActionResult> Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new { result = "error", message = "Can not be empty" });
            }
            if (_context.Subscribers.Any(s => s.Email == email))
            {
                return Json(new { result = "error", message = "You have already subscribed" });

            }

            Subscriber subscriber = new Subscriber()
            {
                Email = email
            };
            await _context.Subscribers.AddAsync(subscriber);
            await _context.SaveChangesAsync();

            return Json(new { result = "success", message = "You have subscribed for news" });

        }
    }
}
