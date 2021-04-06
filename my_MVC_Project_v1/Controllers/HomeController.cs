using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_MVC_Project_v1.Models;

namespace my_MVC_Project_v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AmazingContext db;
        public HomeController(AmazingContext context)
        {
            db = context;
        }
        public IActionResult Index()  // Home Page
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var iletisim = db.Contact.Find(1);
            ViewBag.Adres = iletisim.Address;
            ViewBag.Eposta = iletisim.Email;
            ViewBag.Telefon = iletisim.PhoneNumber;
            return View();
        }
    }
}
