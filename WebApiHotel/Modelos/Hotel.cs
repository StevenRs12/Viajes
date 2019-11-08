using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class Hotel
    {
        [Key]
        [Column(name: "HotId")]
        public int ID { get; set; }
        [Column(name: "Hotnombre")]
        public string Nombre { get; set; }
        [Column(name: "Hotubicacion")]
        public string Ubicacion { get; set; }
        [Column(name: "Hothabilitado")]
        public bool Activo { get; set; }
        [Column(name: "Hottelefono")]
        public Int32 Telefono { get; set; }
        [Column(name: "Hotemail")]
        public string Email { get; set; }
        [Column(name: "Hotfechcrea")]
        public DateTime? FechaCreacion { get; set; }
        [Column(name: "HotUsuCreacion")]
        public int Usuario { get; set; }

    }
}
