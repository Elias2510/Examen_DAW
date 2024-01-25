using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EXAMEN.Controllers.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clasa1Controller : ControllerBase
    {
        private readonly  app_context _context;

        public Clasa1Controller( app_context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Aici poți implementa logica pentru a obține obiectele din Clasa1 din baza de date.
            var clasa1Objects = _context.Clasa1.Include(c1 => c1.Clasa2Reference).ToList();

            return Ok(clasa1Objects);
        }
    }
}
