using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el nombre");

            string nombre = (Console.ReadLine());

            Console.WriteLine("ingrese edad");

            int edad = Convert.ToInt32(Console.ReadLine());

            int cuenta = edad-18;


            if (cuenta >= 0)
            {

                Console.WriteLine("Bienvenido al club, " + nombre );



            }
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
        }

    }
}
