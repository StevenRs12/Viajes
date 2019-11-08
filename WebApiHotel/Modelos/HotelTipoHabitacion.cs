using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class HotelTipoHabitacion
    {
        [Key]
        [Column(name: "HotTipHabId")]
        public int ID { get; set; }

        [Column(name: "HotTipoHabIdTipo")]
        public int IDTipoHabita { get; set; }

        [Column(name: "HotTipoHabIdHot")]
        public int IdHotel { get; set; }
        
    }
}
