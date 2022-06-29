using Day.DAL;
using Day.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.manage.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateAdmin()
        {
            AppUser admin = new AppUser
            {
                FullName="Super Admin",
                UserName = "SuperAdmin"                
            };

          
        }
    }
}
