using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Route("api/ReservaTurista")]
    [ApiController]
    public class ReservaTuristaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReservaTuristaController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public IActionResult CrearReservaTurista([FromBody] List<ReservaTurista> reservaTurista)
        {
            if (ModelState.IsValid)
            {
                _context.ReservaTurista.AddRange(reservaTurista);
                _context.SaveChanges();

                return Ok();
            }
            return BadRequest(ModelState);

        }

    }
}