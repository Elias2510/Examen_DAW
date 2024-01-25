using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EXAMEN.Controllers.Model;  // Asigurați-vă că este inclus namespace-ul corect

namespace EXAMEN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly app_context _context;

        public ValuesController(app_context context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Schimbați 'app' cu numele DbSet-ului dorit (Evenimente, Participanti, Participari, Clasa3)
            var values = _context.Evenimente.Select(e => e.Nume).ToList();
            return values;
        }
    }
}
