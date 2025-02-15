using Microsoft.AspNetCore.Mvc;

namespace araba_kirala.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
