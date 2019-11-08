using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class TipoHabitacion
    {
        [Key]
        [Column(name: "tipoID")]
        public int ID { get; set; }

        [Column(name: "Impuesto")]
        public float Impuesto { get; set; }

        [Column(name: "TipoDesc")]
        public string Descripcion { get; set; }

        [Column(name: "TipoEstado")]
        public bool Estado { get; set; }
        
    }
}
