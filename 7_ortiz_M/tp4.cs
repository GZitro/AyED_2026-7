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


            Console.Write("ingrese un numero: ");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese un segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero1 + numero2 + " si es suma");
            Console.WriteLine(numero1 - numero2 + " si es resta");
            Console.WriteLine(numero1 / numero2 + " si es division");
            Console.WriteLine(numero1 * numero2 + "si es multiplicacion");

        }
    }
}
