using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            primos();
        }

        static void primos()
        {
          
            int divisores = 0;
            Console.Write("Ingrese un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] primos = new int[num];
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisores++;
                   
                    Console.WriteLine(divisores);
                   
                }
                if (divisores==2)
                {

                }
            }


           

          

            }


        }
    }

