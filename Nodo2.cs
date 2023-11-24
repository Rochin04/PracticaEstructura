using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraListasSimple
{
    class Nodo2
    {
        public Perro2 DatosPerro2 { get; set; }
        public Nodo2 Siguiente2 { get; set; }   
        public Nodo2(Perro2 datosPerro2)
        {
            DatosPerro2 = datosPerro2;
            Siguiente2 = null;
        }
    }
}
