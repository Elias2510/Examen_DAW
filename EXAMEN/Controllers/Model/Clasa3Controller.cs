using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EXAMEN.Controllers.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clasa3Controller : ControllerBase
    {
        private readonly app_context _context;

        public Clasa3Controller(app_context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // Aici poți implementa logica pentru a obține obiectele din Clasa3 din baza de date.
            var clasa3Objects = _context.Clasa3.ToList();

            return Ok(clasa3Objects);
        }
    }
}
