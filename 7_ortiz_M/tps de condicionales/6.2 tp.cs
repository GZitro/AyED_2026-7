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
           
            Console.WriteLine("ingrese el numero");

            int num = Convert.ToInt32(Console.ReadLine());

            


            if (num%2==0)
            {

                Console.WriteLine(num + "es par" );



            }
            else
            {
                Console.WriteLine(num + " no es par");
            }
        }

    }
}
