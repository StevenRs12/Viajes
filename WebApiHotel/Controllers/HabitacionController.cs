using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHabel.Modelos;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Produces("application/json")]
    [Route("api/Habitacion")]
    [ApiController]
    public class HabitacionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HabitacionController(ApplicationDbContext context)
        {
            this._context = context;
        }


        [HttpGet("{id}", Name = "HabitacionCreada")]
        public IActionResult ObtenerHabitacion(int id)
        {
            var habitacion = _context.Habitaciones.Where(x => x.ID == id).FirstOrDefault();
            return Ok(habitacion);
        }

        [HttpPost]
        public IActionResult CrearHabitacion([FromBody] Habitacion habitacion)
        {
            if (ModelState.IsValid)
            {
                _context.Habitaciones.Add(habitacion);
                _context.SaveChanges();
                return new CreatedAtRouteResult("HabitacionCreada", new { id = habitacion.ID }, habitacion);
            }
            return BadRequest(ModelState);

        }
    }
}