
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ELEGI UNA OPCION");
            Console.WriteLine("1.Lo devuelves al templo.");
            Console.WriteLine("2.Lo vendes por créditos");
            Console.WriteLine("3.Lo usas para construir un arma roja");

            int numero = Convert.ToInt32(Console.ReadLine());






            if (numero == 1)
            {

                Console.WriteLine("El camino del Jedi sigue");

            }
            if (numero == 2)
            {

                Console.WriteLine("Un cazarrecompensas eres");

            }
            if (numero == 3)
            {

                Console.WriteLine("El Lado Oscuro se apodera de ti");

            }
            else
            {
                Console.WriteLine("Error en la Fuerza: opción inválida");



            }
        }
    }
}
