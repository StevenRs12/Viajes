using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class ReservaTurista
    {
        [Key]
        [Column(name: "Id")]
        public int ID { get; set; }

        [Column(name: "IdReserva")]
        public int IdReserva { get; set; }

        [Column(name: "IdTurista")]
        public int IdTurista { get; set; }

    }
}
