namespace PracticaEstructuraListasSimple
{                           
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListaEnlasada listaPerros = new ListaEnlasada();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Ingrese los detalles del perro:");

            //    Console.Write("Color: ");
            //    string color = Console.ReadLine();

            //    Console.Write("Número de patas: ");
            //    int numeroDePatas = int.Parse(Console.ReadLine());

            //    Console.Write("Raza: ");
            //    string raza = Console.ReadLine();

            //    Perro nuevoPerro = new Perro(color, numeroDePatas, raza);
            //    listaPerros.AgregarPerro(nuevoPerro);
            //}

            //Console.WriteLine("\nLista de perros:");
            //listaPerros.ImprimirLista();
            ListaEnlazada2 listasEnlazadas2 = new ListaEnlazada2();
            Console.WriteLine("ingresa la cantidad de registros");
            int cantRegistros = int.Parse(Console.ReadLine());
            //for(int i = 0; i < cantRegistros; i++)
            //{
                //Console.WriteLine($"/////{i}/////");
                //Console.WriteLine("Ingresa el nombre del perro");
                string nombre = "perro1";
                //Console.WriteLine("Ingresa la raza del perro");
                string raza = "raza1";
            //Console.WriteLine("Ingresa el color del perro");
            string color = "color1";
            Perro2 perro2 = new Perro2(nombre, raza, color);
                listasEnlazadas2.AgregarAlFiinal(perro2);
            //}
            for (int i = 0; i < cantRegistros; i++)
            {
                Console.WriteLine($"/////{i} agregar al principio /////");
                Console.WriteLine("Ingresa el nombre del perro");
                string nombreF = Console.ReadLine();
                Console.WriteLine("Ingresa la raza del perro");
                string razaF = Console.ReadLine();
                Console.WriteLine("Ingresa el color del perro");
                string colorF = Console.ReadLine();
                Perro2 perro2F = new Perro2(nombreF, razaF, colorF);
                listasEnlazadas2.AgrregarPerro2(perro2F);
            }
            for (int i = 0; i < cantRegistros; i++)
            {
                Console.WriteLine($"/////{i} agregar en medio /////");
                Console.WriteLine("Ingresa el nombre del perro");
                string nombreF = Console.ReadLine();
                Console.WriteLine("Ingresa la raza del perro");
                string razaF = Console.ReadLine();
                Console.WriteLine("Ingresa el color del perro");
                string colorF = Console.ReadLine();
                Perro2 perro2F = new Perro2(nombreF, razaF, colorF);
                listasEnlazadas2.AgregarPerroEnMedio(perro2F);
            }
            Console.WriteLine("\nLista de perros\n");
            listasEnlazadas2.Imprimir2();

        }
    }
}