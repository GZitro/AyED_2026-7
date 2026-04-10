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

            Console.WriteLine("ingrese numero");

            int num = Convert.ToInt32(Console.ReadLine());



            int numero = num % 5;


            if (numero == 0)
            {

                Console.WriteLine("clima agradable");

            }
            else
            {
                Console.WriteLine("juli");
            }


        }

    }
}


