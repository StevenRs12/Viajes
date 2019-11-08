using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Modelos
{
    public class Usuario
    {
        [Key]
        [Column(name: "IdUsuario")]
        public int ID { get; set; }

        [Column(name: "nombreUsu")]
        public string nombreUsuario { get; set; }

        [Column(name: "ApeUsu")]
        public string ApellidoUsuario { get; set; }

        [Column(name: "EmailUsu")]
        public string EmailUsuario { get; set; }

        [Column(name: "ClaveUsu")]
        public string ClaveUsu { get; set; }

        [Column(name: "TipoAdmin")]
        public bool TipoAdmin { get; set; }

    }
}
