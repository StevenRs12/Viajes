using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHabel.Modelos;

namespace WebApiHotel.Modelos
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hoteles { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<HotelTipoHabitacion> HotelTipoHabitacion { get; set; }
        public DbSet<TipoHabitacion> TipoHabitacion { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Turista> Turista { get; set; }
        public DbSet<ReservaTurista> ReservaTurista { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
