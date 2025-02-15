using araba_kirala.Data;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
namespace araba_kirala.ViewComponet
{
    public class BestOffer:ViewComponent
    {
        private readonly Context _context;

        public BestOffer(Context context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var carliste = _context.Cars.ToList();
            return View(carliste);
        }
    }
}
