using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra2
{
   public class Mantenimientos
    {
        public string Tipo { get; set; } // Preventivo o Correctivo
        public DateTime Fecha { get; set; }
        public string Tecnico { get; set; }
        public string Descripcion { get; set; }
    }
}
