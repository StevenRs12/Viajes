using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHabel.Modelos
{
    public class Habitacion
    {
        [Key]
        [Column(name: "HabID")]
        public int ID { get; set; }
        [Column(name: "HabNum")]
        public int NumHabitacion { get; set; }
        [Column(name: "HabIdTipHab")]
        public int IdTipoHabitacion { get; set; }
        [Column(name: "HabCosto")]
        public Decimal Costo { get; set; }
        [Column(name: "HabEstado")]
        public bool Estado { get; set; }
        [Column(name: "HabIdHot")]
        public int IdHotel { get; set; }
        [Column(name: "HabReserva")]
        public bool Reserva { get; set; }
    }
}
