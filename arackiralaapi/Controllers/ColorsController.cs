using arabakiralaapi.Models;
using arackiralaapi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace arackiralaapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class ColorsController : ControllerBase
    {
        private readonly Context _context;

        public ColorsController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Colors>>> GetColor()
        {
            return await _context.Colors.ToListAsync();
        }
        [HttpGet("id")]
        public async Task<ActionResult<Colors>>GetColorId(int id)
        {
            return await _context.Colors.FindAsync(id);
        }
        [HttpPost]  
        public async Task<ActionResult>AddColor(Colors gelen)
        {
            _context.Colors.Add(gelen);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("id")]
        public async Task<ActionResult<Colors>>DeleteColor(int id)
        {
            var bul = _context.Colors.Find(id);
            if (bul != null)
            {
                _context.Remove(bul);
               await _context.SaveChangesAsync();
            }
            return bul;
        }
        [HttpPut("id")]
        public async Task<ActionResult<Colors>>EditColor(Colors color,int id)
        {
            var bul= await _context.Colors.FindAsync(id);
            if(bul!= null)
            {
                bul.ColorName = color.ColorName;
                _context.Colors.Update(bul);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return bul;
        }
    }
}
