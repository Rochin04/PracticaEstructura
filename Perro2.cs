using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraListasSimple
{
    class Perro2
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public Perro2(string nombre, string raza, string color)
        {
            Nombre = nombre;
            Raza = raza;
            Color = color;
        }
    }
}
