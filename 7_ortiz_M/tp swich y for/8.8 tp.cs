using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la temperatura de los ultimos 7 dias");

            int acumulador = 0;
            int contador = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.Write("dia " + i + " temperatura: ");

                int temp = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + temp;

                if (temp <0)
                {
                    contador++;

                }
            }
            Console.WriteLine(acumulador + " temperatura total");
            Console.WriteLine(contador+ " dias fueron menos de 0 grados");
        }
    }
    }

