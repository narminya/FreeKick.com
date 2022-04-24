using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Repository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models.ViewModels;
using WebUI.Utilities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;
        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            var cv = new CreateNewsViewModel()
            {
                Tags = _context.Tags.ToList()
            };
            return View(cv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateNewsViewModel cv)
        {
            cv.Tags = _context.Tags.ToList();
            if (!ModelState.IsValid)
            {
                return View(cv);
            }

            if (cv.File == null)
            {
                ModelState.AddModelError(nameof(CreateNewsViewModel.File), "Please upload an image");
                return View(cv);
            }
            if (!cv.File.IsContains())
            {
                ModelState.AddModelError(nameof(CreateNewsViewModel.File), "Uploaded image is not supported");
                return View(cv);
            }
            var picture = FileUtil.FileCreate(cv.File, FileConstant.ImagePath, "news");
            
            var result = new News() { Title = cv.Title, Description = cv.Description, Image=picture };
            var newsTag = new List<NewsTag>();
            foreach (var item in cv.Tagsx)
            {
                newsTag.Add(new NewsTag { NewsId = result.Id, TagId = item });
            }
            result.Tags = newsTag;
           await _context.AddAsync(result);
           await _context.SaveChangesAsync();

            return RedirectToAction("Index", "News", new { Id=result.Id});
        }
    }
}
