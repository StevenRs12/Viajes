using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Produces("application/json")]
    [Route("api/Turista")]
    [ApiController]

    public class TuristaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public TuristaController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public List<Turista> Obtener()
        {
            return _context.Turista.ToList();
        }

        [HttpGet("{id}", Name = "TuristaCreado")]
        public IActionResult ObtenerTurista(int id)
        {
            var turista = _context.Turista.Where(x => x.ID == id).FirstOrDefault();
            return Ok(turista);
        }


        [HttpPost]
        public IActionResult CrearTurista([FromBody] Turista turista)
        {
            if (ModelState.IsValid)
            {
                _context.Turista.Add(turista);
                _context.SaveChanges();
                return new CreatedAtRouteResult("TuristaCreado", new { id = turista.ID }, turista);
            }
            return BadRequest(ModelState);

        }
    }
}