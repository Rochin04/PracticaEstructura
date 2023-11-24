using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraListasSimple
{
    class ListaEnlasada
    {
        private Nodo primero;

        public ListaEnlasada()
        {
            primero = null;
        }

        public void AgregarPerro(Perro datosPerro)
        {
            Nodo nuevoNodo = new Nodo(datosPerro);
            nuevoNodo.Siguiente = primero;
            primero = nuevoNodo;
        }

        public void ImprimirLista()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine($"Color: {actual.DatosPerro.Color}, Patas: {actual.DatosPerro.NumeroDePatas}, Raza: {actual.DatosPerro.Raza}");
                actual = actual.Siguiente;
            }
        }
    }
}
