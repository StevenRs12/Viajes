using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Route("api/Reservas")]
    [ApiController]
    public class ReservaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public ReservaController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public List<Reservas> Obtener()
        {
            return _context.Reservas.ToList();
        }


        [HttpGet("{id}", Name = "ReservasCreado")]
        public IActionResult ObtenerReserva(int id)
        {
            var reservas = _context.Reservas.Where(x => x.ID == id).FirstOrDefault();
            return Ok(reservas);
        }

        [HttpPost]
        public IActionResult CrearReserva([FromBody] Reservas reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
                
                return new CreatedAtRouteResult("TuristaCreado", new { id = reserva.ID }, reserva);
            }
            return BadRequest(ModelState);

        }

    }
}