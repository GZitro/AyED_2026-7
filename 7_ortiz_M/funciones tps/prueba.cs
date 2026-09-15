using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double limite =6247642549258932538 ; 

            for (double i = 1; i <= limite; i++)
            {
                double numeroActual = i;
                Console.WriteLine($"\n--- Secuencia para el número {i} ---");

                while (numeroActual != 1)
                {
                    if (numeroActual % 2 == 0)
                    {
                        numeroActual = numeroActual / 2;
                    }
                    else
                    {
                        numeroActual = numeroActual * 3 + 1;
                    }
                    Console.WriteLine(numeroActual);
                }
            }

            Console.ReadLine();
        }
    }
}
