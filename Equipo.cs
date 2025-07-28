using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_progra2
{
    public class Equipo
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }

        public List<Mantenimientos> Mantenimientos { get; set; } = new List<Mantenimientos>();
    }
}

