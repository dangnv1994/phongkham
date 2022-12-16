using Microsoft.AspNetCore.Mvc;
using PKBsHue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKBsHue.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users request )
        {
            return View();
        }
    }
}
