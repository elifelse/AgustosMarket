using AgustosMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly UygulamaDbContext _context;

        public UrunlerController(UygulamaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yeni()
        {
            ViewBag.Kategoriler = _context.Kategoriler.Select(k => new SelectListItem()
            {
                Text = k.KategoriAd,
                Value = k.Id.ToString()
            }).ToList();
            return View();
        }

        [HttpPost]

        public IActionResult Yeni(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urun);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kategoriler = _context.Kategoriler.Select(k => new SelectListItem()
            {
                Text = k.KategoriAd,
                Value = k.Id.ToString()
            }).ToList();

            return View();
        }
    }
}
