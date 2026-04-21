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
            Console.WriteLine("ingrese los cm de un lado");

            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese los cm del otro lado");

            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese los cm del ultimo lado");

            int lado3 = Convert.ToInt32(Console.ReadLine());


            if (lado1 == lado2)
            {
                if (lado1 == lado3)
                {
                    Console.WriteLine("equilatero");
                }
            }
            if (lado1 != lado3)
            {

                if (lado1 == lado2)
                {
                    Console.WriteLine("isoceles");
                }
            }
            if (lado1 != lado2)
            {

                if (lado1 == lado3)
                {
                    Console.WriteLine("isoceles");
                }
            }
            if (lado1 != lado2)
            {
                if (lado1 != lado3)
                {
                    Console.WriteLine("escaleno");
                }
                }
        }

    }
}
    

