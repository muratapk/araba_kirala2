using araba_kirala.Dto;
using araba_kirala.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace araba_kirala.Controllers
{
    public class RegisterController : Controller
    {
        //ogrenci murat=new ogrenci();
        //ogrenci havva;
        //hava=new ogrenci()
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //buradaki tanımlayı yapmadığım dolayı kayıt gerçekleşmiyor

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppRegisterDto gelen)
        {
            Random rnd = new Random();
            int code = 0;
            code = rnd.Next(100000,1000000);
            AppUser appuser = new AppUser()
            {
                FirstName = gelen.FirstName,
                LastName = gelen.LastName,
                City = gelen.City,
                UserName = gelen.UserName,
                Password=gelen.Password,
                Email = gelen.Email,
                ConfirmCode = code,
            };
            var result = await _userManager.CreateAsync(appuser, gelen.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Main");
            }
            else
            {
                return View();
            }

            return View();
        }

    }
}
