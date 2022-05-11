using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models.ViewModels.Teams;
using WebUI.Utilities;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamsController : Controller
    {
        private readonly AppDbContext _context;
        public TeamsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            return View();
        }
        public IActionResult Create()
        {
            var tcv = new TeamCreateViewModel()
            {
                Countries = _context.Country.ToList(),
                Tags = _context.Tags.ToList()
            };
            return View(tcv);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeamCreateViewModel tcv)
        {
            tcv.Countries = _context.Country.ToList();
            tcv.Tags = _context.Tags.ToList();
            if (!ModelState.IsValid)
            {
                return View(tcv);
            };

            if (tcv.Logo == null)
            {
                ModelState.AddModelError(nameof(TeamCreateViewModel.Logo), "Please upload an image");
                return View(tcv);
            }
            if (!tcv.Logo.IsContains())
            {
                ModelState.AddModelError(nameof(TeamCreateViewModel.Logo), "Uploaded image is not supported");
                return View(tcv);
            }
            var logo = FileUtil.FileCreate(tcv.Logo, FileConstant.ImagePath, "teams");
            if (tcv.Title == null)
            {
                ModelState.AddModelError(nameof(TeamCreateViewModel.Title), "Please upload an image");
                return View(tcv);
            }
            if (!tcv.Title.IsContains())
            {
                ModelState.AddModelError(nameof(TeamCreateViewModel.Title), "Uploaded image is not supported");
                return View(tcv);
            }
            var titleImage = FileUtil.FileCreate(tcv.Logo, FileConstant.ImagePath, "titleImages");
            var team = new Team
            {
                Coach = tcv.Coach,
                CountryId = tcv.CountryId,
                Logo = logo,
                TitleImage = titleImage,
                Name = tcv.Name,
                Stadium = tcv.Stadium,
                CreatedDate = DateTime.Now,
                 TagId = (int)tcv.TagId
            };


            return RedirectToAction("Index", "Home", new { area = "" });
        }



        public IActionResult Update(int? id)
        {
            return View();
        }
        public IActionResult Delete(int? id)
        {
            return View();
        }
    }
}
