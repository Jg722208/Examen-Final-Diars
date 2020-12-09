using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_N00024113.Models
{
    public class Nota
    {
        public int Id { set; get; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Titulo { set; get; }
        public DateTime Fecha { set; get; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Contenido { set; get; }

    }
}
