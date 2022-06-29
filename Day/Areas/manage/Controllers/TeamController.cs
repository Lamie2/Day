using Day.DAL;
using Day.Helpers;
using Day.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.manage.Controllers
{
    [Area("manage")]

    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var model = _context.TeamMembers.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamMember teamMember)
        {
            if (teamMember.ImageFile!=null)
            {
                if (teamMember.ImageFile.ContentType!="image/png" && teamMember.ImageFile.ContentType!="image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Image type must peng or jpeg");
                }
                if (teamMember.ImageFile.Length>2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image size muset be less than 2MB");
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Image file is required");
            }

            teamMember.Image = FileManager.Save(_env.WebRootPath, "uploads, teamMembers", teamMember.ImageFile);
            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
          TeamMember teamMember = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (teamMember==null)
            {
                return NotFound();
            }
            _context.TeamMembers.Remove(teamMember);
            _context.SaveChanges();
            return View();
        }
        
        public IActionResult Edit(int id)
        {
            TeamMember existMember = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (existMember==null)
            {
                return RedirectToAction("dashboard", "error");
            }
            return View();        }
    }
}
