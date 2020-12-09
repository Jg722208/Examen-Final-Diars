using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_N00024113.Models
{
    public class EtiquetaNota
    {
        public int Id { get; set; }
        public int IdEtiqueta { get; set; }
        public int IdNota { get; set; }
        public Etiqueta Etiqueta { get; set; }



    }
}
