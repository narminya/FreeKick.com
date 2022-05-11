using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
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
    public class PlayerController : Controller
    {
        private readonly AppDbContext _context;
        public PlayerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            var model = new PlayerCreateViewModel()
            {
                Tags = _context.Tags.ToList(),
                Position = _context.Positions.ToList()


            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(PlayerCreateViewModel model)
        {
            model.Tags = _context.Tags.ToList();
            model.Position = _context.Positions.ToList();

            model.Tags = _context.Tags.ToList();
            if (!ModelState.IsValid)
            {
                return View(model);
            };

            if (model.Picture == null)
            {
                ModelState.AddModelError(nameof(PlayerCreateViewModel.Picture), "Please upload an image");
                return View(model);
            }

            if (!model.Picture.IsContains())
            {
                ModelState.AddModelError(nameof(PlayerCreateViewModel.Picture), "Uploaded image is not supported");
                return View(model);
            }
            var logo = FileUtil.FileCreate(model.Picture, FileConstant.ImagePath, "teams");

            var player = new Player()
            {
                Name = model.Name,
                Surname = model.Surname,
                Picture = logo,
                CreatedDate = DateTime.Now,
                DateOfBirth = model.DateOfBirth,
                TagId = model.TagId


            };
            return View("Index","Dashboard");
        }


        public IActionResult Transfer(int id)
        {
            var playerTeam = new PlayerTransferViewModel
            {
                Positions = _context.Positions.ToList(),
                Teams = _context.Teams.ToList()
            };
            return View(playerTeam);
        }

        public IActionResult Transfer(int id, PlayerTransferViewModel model)
        {
            //var player = _context.

            //model.Positions = _context.Positions.ToList();
            //model.Teams = _context.Teams.ToList();
            //if (!ModelState.IsValid)
            //{

            //    return View(model);
            //}
            return View();
        }
    }
}
