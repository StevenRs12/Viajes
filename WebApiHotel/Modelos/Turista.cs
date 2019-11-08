using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class Turista
    {
        [Key]
        [Column(name: "IdTurista")]
        public int ID { get; set; }

        [Column(name: "NombreTur")]
        public string NombreTurista { get; set; }

        [Column(name: "ApeTur")]
        public string ApellidoTurista { get; set; }

        [Column(name: "FechaNaci")]
        public DateTime FechaNacimiento { get; set; }

        [Column(name: "genero")]
        public string Genero { get; set; }

        [Column(name: "TipoId")]
        public string TipoId { get; set; }

        [Column(name: "NoID")]
        public int NumeroID { get; set; }

        [Column(name: "Email")]
        public string Email { get; set; }

        [Column(name: "Telefono")]
        public int Telefono { get; set; }

    }


}
