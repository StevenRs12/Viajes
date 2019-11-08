using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHotel.Modelos;

namespace WebApiHotel.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public UsuarioController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public List<Usuario> Obtener()
        {
            return _context.Usuario.ToList();
        }
    }
}