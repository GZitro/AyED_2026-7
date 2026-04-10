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

            Console.WriteLine("ingrese su edad");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la edad de la otra persona ");

            int num2 = Convert.ToInt32(Console.ReadLine());



            


            if (num1 >num2 )
            {
                int numero1 = num1 - num2;

                Console.WriteLine(num1 + " años tiene el mayor y "+ numero1+ " años es la diferencia que hay");

            }
            if (num1 < num2)
            {
                int numero1 = num2 - num1;

                Console.WriteLine(num2 + " años tiene el mayor y " + numero1 + " años es la diferencia que hay");

            }

        }

    }
}


