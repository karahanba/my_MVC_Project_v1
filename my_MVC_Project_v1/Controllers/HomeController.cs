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
            var iletisim = db.Contact.Find(1);
            ViewBag.Gizlilik = iletisim.Privacy;
            return View();
        }
        
        public IActionResult About() // this will be included in Index
        {
            return View();
        }

        public IActionResult Contact()
        {
            var iletisim = db.Contact.Find(1);
            ViewBag.Adres = iletisim.Address;
            ViewBag.Eposta = iletisim.Email;
            ViewBag.Telefon = iletisim.PhoneNumber;

            ViewBag.Hakkinda = iletisim.About;// bu başka yere
            ViewBag.Face = iletisim.Facebook;
            ViewBag.Twit = iletisim.Twitter;
            ViewBag.Insta = iletisim.Instagram;
            ViewBag.Lkin = iletisim.Linkedin;

            //    public string About { get; set; }
            //public string Privacy { get; set; }
            //public string Facebook { get; set; }
            //public string Twitter { get; set; }
            //public string Instagram { get; set; }
            //public string Linkedin { get; set; }
            return View();
        }

        public IActionResult Products()
        {
            return View(db.Products.ToList());
        }

        // Detay için ayrı bir metod...seçilen ürünü sepete eklemek için benzer bir yol izlenebilir...
        //public IActionResult Detail(int id)
        //{
        //    return View(db.Products.Find(id));
        //}
    }
}
