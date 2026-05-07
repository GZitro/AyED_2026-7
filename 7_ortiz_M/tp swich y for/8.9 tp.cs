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
            Console.WriteLine("ingrese el gasto de los ultimos 7 dias");

            int acumulador = 0;
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("dia "+ i + " cuanto gasto? " );

                int plata = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador+ plata;

                if (plata>500)
                {
                    contador++;
                    
                }
            }
            Console.WriteLine(acumulador+ " gasto en total");
            Console.WriteLine(contador + " dia mas de 500");
        }
    }
}
