using Domain.Dto;
using Domain.Entity;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;
        public NewsController(AppDbContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
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
            
            news.ViewCount++;
            _context.Entry(news).State = EntityState.Modified;
            _context.SaveChanges();
            var model = new NewsViewModel()
            {
                News = news,
                Tags = await _context.NewsTag.Where(t => t.NewsId == news.Id).Select(x =>
                new Tag
                {
                    Name = x.Tag.Name,
                    
                }).ToListAsync(),
                Time = news.CreatedDate.ToRelativeDate()
            };

            return View(model);
        }

        public IActionResult ByTag(int? id)
        {
            ViewBag.Id = _context.Tags.Find(id);
            var news = _context.NewsTag.Where(c => c.TagId == id).Select(c => new NewsViewModel
            {
                News = new News { Id = c.NewsId, Description =c.News.Description, Image = c.News.Image, Title = c.News.Title},
                 Tags =  _context.Tags.Where(v=>v.Id==c.Id).ToList(),
                Time = c.News.CreatedDate.ToRelativeDate()

            }).ToList();






            return View(news);
        }

        //public async Task<PartialViewResult> Comment(string content)
        //{
        //    var user = await _userManager.GetUserAsync(HttpContext.User);
        //    var comment = new Comment()
        //    {
        //        Content = content,
        //        HotelId = Convert.ToInt32(TempData["Id"]),
        //        User = user
        //    };

        //    await _dt.Comment.AddAsync(comment);
        //    await _dt.SaveChangesAsync();
        //    return PartialView("_CommentPartial", comment);
        //}


    }
}
