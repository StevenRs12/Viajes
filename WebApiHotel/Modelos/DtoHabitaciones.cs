using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class DtoHabitaciones
    {
        public int ID { get; set; }
        
        public int NumHabitacion { get; set; }
        
        public string DescripcionHabitacion { get; set; }
        
        public Decimal Costo { get; set; }
        
        public bool Estado { get; set; }
       
        public int IdHotel { get; set; }
        
        public bool Reserva { get; set; }

        public List<Reservas> Reservas { get; set; }
    }
}
