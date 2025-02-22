using araba_kirala.Data;
using araba_kirala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;

namespace araba_kirala.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,Context context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            var bilgi = _context.Cars.Include(c => c.Brands).Include(c => c.Colors).Where(x => x.CarID == id).FirstOrDefault();

            if (bilgi == null)
            {
                // Car bulunamadı, bir hata mesajı verebilirsiniz
                return View("Error");  // Veya uygun bir hata sayfası
            }

            return View(bilgi);


        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
