using araba_kirala.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace araba_kirala.Controllers
{
    public class ColorApiController : Controller
    {
        Uri _baseAddress = new Uri("https://localhost:7086/api/");
        //verileri çekeceğimiz adresimiz buraya tanımlıyorum
        private readonly HttpClient _client;

        public ColorApiController()
        {
            
            _client = new HttpClient();
            _client.BaseAddress = _baseAddress;
        }

        [HttpGet]
        //veri listeme için kullanılan yapı 
        public IActionResult GetColors()
        {
            List<Colors> color = new List<Colors>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "Colors/Get").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                color = JsonConvert.DeserializeObject<List<Colors>>(data); // JSON dizisini deserialize et
            }

            return View(color); // color listesine gelen verileri View'a gönder
        }

    }
}
