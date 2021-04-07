using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_MVC_Project_v1.Models;

namespace my_MVC_Project_v1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InfoController : Controller
    {
        private readonly AmazingContext db;
        public InfoController(AmazingContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInfo(_Iletisim ıletisim)
        {
            db.Contact.Add(ıletisim);
            bool result = db.SaveChanges() > 0 ? true : false;
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(ıletisim);
        }

        public IActionResult Edit()
        {
            return View(db.Contact.Find(1));
        }

        [HttpPost]
        public IActionResult Edit(_Iletisim ıletisim)
        {
            db.Entry(ıletisim).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.Contact.Update(ıletisim);  // böyle de yapılabilirdi.
            bool result = db.SaveChanges() > 0 ? true : false;
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(ıletisim);
        }
    }
}
