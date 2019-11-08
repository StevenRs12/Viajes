using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class Reservas
    {
        [Key]
        [Column(name: "ReservaId")]
        public int ID { get; set; }

        [Column(name: "ReservaIdhabita")]
        public int ReservaIdhabita { get; set; }

        [Column(name: "ReservaFecIni")]
        public DateTime ReservaFecIni { get; set; }

        [Column(name: "ReservaFecFin")]
        public DateTime ReservaFecFin { get; set; }

        [Column(name: "ReservaIdTurista")]
        public int ReservaIdTurista { get; set; }

        [Column(name: "ReservaIdUsuario")]
        public int ReservaIdUsuario { get; set; }

    }
}
