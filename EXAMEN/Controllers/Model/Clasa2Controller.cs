using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EXAMEN.Controllers.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clasa2Controller : ControllerBase
    {
        private readonly  app_context _context;

        public Clasa2Controller(app_context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Aici poți implementa logica pentru a obține obiectele din Clasa2 din baza de date.
            var clasa2Objects = _context.Clasa2.Include(c2 => c2.Clasa3Reference).ToList();

            return Ok(clasa2Objects);
        }
    }
}