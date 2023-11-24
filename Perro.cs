using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraListasSimple
{
    class Perro
    {
        public string Color { get; set; }
        public int NumeroDePatas { get; set; }
        public string Raza { get; set; }

        public Perro(string color, int numeroDePatas, string raza)
        {
            Color = color;
            NumeroDePatas = numeroDePatas;
            Raza = raza;
        }
    }
}
