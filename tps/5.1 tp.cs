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
            Console.Write("cuanto es el nivel midiclorianos?: ");

            int poder = Convert.ToInt32(Console.ReadLine());

            if (poder >= 15000)
            {

                Console.WriteLine("potencial maestrojedi detectado. avisa al consejo");

            }
            if (5000 < poder)
            {
                if (poder<15000)
                    { 
                Console.WriteLine("Aceptable para entrenamiento Padawan.");
                     }
                }
            else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza");

            }
        }

    }
}

        