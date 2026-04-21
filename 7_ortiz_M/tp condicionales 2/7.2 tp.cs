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
            Console.WriteLine("ingrese su peso");

            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese su altura");

            double altura = Convert.ToDouble(Console.ReadLine());

            double altura2 = (altura * altura);

            double imc = peso/altura2;

            if (imc > 25)
            {
                Console.WriteLine("sobrepeso");
            }
            if (imc < 25)
            {
                
                
                    Console.WriteLine("normal");
                
            }

        }
        
    }
}
