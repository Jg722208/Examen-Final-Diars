using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_N00024113.Models
{
    public class Usuario
    {
        public int Id{ get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
