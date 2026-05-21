using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nota");
            int nota;
            do
            {
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota <= 10 && nota >= 0)
                {

                    Console.WriteLine("su nota es " + nota);
                }
                else
                {
                    Console.WriteLine("error");
                }

            } while (nota > 10 && nota > 0);
        }

    }
}
