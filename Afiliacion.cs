using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidosPoliticps
{
    internal class Afiliacion
    {
        string partido;
        int dpi;
        string fechaAfliacion;

        public string Partido { get => partido; set => partido = value; }
        public int Dpi { get => dpi; set => dpi = value; }
        public string FechaAfliacion { get => fechaAfliacion; set => fechaAfliacion = value; }
    }
}
