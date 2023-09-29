using eticaret34.Data;
using eticaret34.Models;
using Microsoft.AspNetCore.Mvc;

namespace eticaret34.Controllers
{
    public class AnasayfaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnasayfaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Urunler()
        {
            List<Category> kategoriler= _context.Categories.ToList();
            ViewBag.kategori= kategoriler;
            var urunler = _context.Products.ToList();
            return View(urunler);
        }
        [HttpGet]
        public IActionResult UrunDetay(int id)
        {
            var urun = _context.Products.Find(id);
            return View(urun);
        }
        public IActionResult RealtedProduct()
        {
            var urunler = _context.Products.ToList();
            return View(urunler);
        }

    }
}
