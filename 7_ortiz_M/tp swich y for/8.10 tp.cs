using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero entero positivo");
            int contador1 = 0; 
            int contador = 0;
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                if (num % i == 0)
                {
                    contador++;
                    contador1++;
                    if (contador1 == 2)

                        Console.WriteLine(i + " primer divisor");
                }
            

            
            }

            if (contador == 2)
            {
                Console.WriteLine(num + " es primo");

            }
            else
            {
                Console.WriteLine(num + " no es primo");
            }
        }

    }
}
