using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Produces("application/json")]
    [Route("api/Hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HotelController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public List<Hotel> Obtener()
        {
            return _context.Hoteles.ToList();
        }

        [HttpGet("{id}", Name = "HotelCreado")]
        public IActionResult ObtenerHotel(int id)
        {
            var hotel = _context.Hoteles.Where(x => x.ID == id).FirstOrDefault();
            return Ok(hotel);
        }
        [HttpPost]
        public IActionResult CrearHotel([FromBody] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _context.Hoteles.Add(hotel);
                _context.SaveChanges();
                return new CreatedAtRouteResult("HotelCreado", new { id = hotel.ID }, hotel);
            }
            return BadRequest(ModelState);

        }

        [HttpPut("{id}")]
        public IActionResult ActualizarHotel([FromBody] Hotel hotel, int id)
        {
            if (hotel.ID != id)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();

        }


        [HttpGet]
        [Route("{id}/Habitacion")]
        public IActionResult ObtenerHabitacionesPorHotel(int id)
        {
            List<DtoHabitaciones> hab = new List<DtoHabitaciones>();
            hab = (from x in _context.Habitaciones
                   join r in _context.HotelTipoHabitacion on x.IdTipoHabitacion equals r.ID
                   join t in _context.TipoHabitacion on r.IDTipoHabita equals t.ID
                   where x.IdHotel.Equals(id)
                   select new DtoHabitaciones
                   {
                       ID = x.ID,
                       DescripcionHabitacion = t.Descripcion,
                       NumHabitacion = x.NumHabitacion,
                       Costo = x.Costo,
                       Estado = x.Estado,
                       IdHotel = x.IdHotel,
                       Reserva = x.Reserva,
                       Reservas = (from rese in _context.Reservas
                                   where rese.ReservaIdhabita.Equals(x.ID)
                                   select new Reservas
                                   {
                                       ID = rese.ID,
                                       ReservaIdhabita = x.ID,
                                       ReservaFecIni = rese.ReservaFecIni,
                                       ReservaFecFin = rese.ReservaFecFin
                                   }).ToList()
                   }).ToList();
               
            return Ok(hab);
        }
    }
}