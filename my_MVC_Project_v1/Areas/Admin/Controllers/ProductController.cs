using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_MVC_Project_v1.Models;

namespace my_MVC_Project_v1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AmazingContext db;
        public ProductController(AmazingContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult AddProduct() // Ayrıca post metodunu da yazıyoruz
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Urunler urunler)
        {
            db.Products.Add(urunler);
            bool result = db.SaveChanges() > 0 ? true : false;
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(urunler);
        }

        public IActionResult Edit(int id)
        {
            return View(db.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Urunler urunler)
        {
            db.Entry(urunler).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //db.Products.Update(urunler);  // böyle de yapılabilirdi.
            bool result = db.SaveChanges() > 0 ? true : false;
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View(urunler);
        }

        public IActionResult Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            bool result = db.SaveChanges() > 0 ? true : false;
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
