using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstructuraListasSimple
{
    class ListaEnlazada2
    {
        private Nodo2 primero2;
        public ListaEnlazada2()
        {
            primero2 = null;
        }
        public void AgrregarPerro2(Perro2 perro2)
        {
            Nodo2 nodo2 = new Nodo2(perro2);
            nodo2.Siguiente2 = primero2;
            primero2 = nodo2;
        }
        ///mas formas de agregar
        public void AgregarAlFiinal(Perro2 perro2)
        {
            Nodo2 nodo2Final = new Nodo2(perro2);
            if (primero2 == null)
            {
                primero2 = nodo2Final;
            }
            else
            {
                Nodo2 actualFinal = primero2;
                while (actualFinal.Siguiente2 != null)
                {
                    actualFinal = actualFinal.Siguiente2;
                }
                actualFinal.Siguiente2 = nodo2Final;
            }
        }
        public int LongitudListad()
        {
            int contador = 0;
            Nodo2 actual = primero2;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente2;
            }

            return contador;

        }
        public void AgregarPerroEnMedio(Perro2 perro2M)
        {
            //aqui hay que calcular la posicion recorriendo la lista con un contador que nos diga la cantidad de elementos que hay en la lista
            int posicion = LongitudListad() / 2;
            //AgregarPerroEnMedio(perro2M, posicion);
            if (posicion < 0)
            {
                Console.WriteLine("Posición inválida");
                return;
            }

            Nodo2 nuevoNodo = new Nodo2(perro2M);

            if (posicion == 0)
            {
                // Agregar al inicio si la posición es 0
                nuevoNodo.Siguiente2 = primero2;
                primero2 = nuevoNodo;
            }
            else
            {
                Nodo2 actualM = primero2;
                int contador = 0;

                while (actualM != null && contador < posicion - 1)
                {
                    actualM = actualM.Siguiente2;
                    contador++;
                }

                if (actualM != null)
                {
                    nuevoNodo.Siguiente2 = actualM.Siguiente2;
                    actualM.Siguiente2 = nuevoNodo;
                }
                else
                {
                    Console.WriteLine("Posición fuera de rango");
                }
            }
        }

        public void Imprimir2()
        {
            Nodo2 actual2 = primero2;
            while (actual2 != null)
            {
                Console.WriteLine($"Nombre {actual2.DatosPerro2.Nombre}, Raza {actual2.DatosPerro2.Raza}, Color {actual2.DatosPerro2.Color}");
                actual2 = actual2.Siguiente2;
            }
        }
        //public void Imprimir2F()
        //{
        //    Nodo2 actual2 = primero2;
        //    while (actual2 != null)
        //    {
        //        Console.WriteLine($"Nombre {actual2.DatosPerro2.Nombre}, Raza {actual2.DatosPerro2.Raza}, Color {actual2.DatosPerro2.Color}");
        //        actual2 = actual2.Siguiente2;
        //    }
        //}
    }
}
