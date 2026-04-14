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
            Console.Write("cuantos años luz hay que viajar?: ");

            int luz = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuantos litros de gasolina hay?: ");

            int litros = Convert.ToInt32(Console.ReadLine());

            int calculo = (luz * 12) - litros;
            if (litros / luz >= 12)
            {

                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");

            }

            else
            {
                Console.WriteLine("Peligro: Combustible insuficiente." + calculo + " Faltan litros");

            }
        }

    }
}

