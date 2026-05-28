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

            Console.WriteLine("ingrese su numero");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {

                Console.WriteLine("numero " + num);
                num--;
            } while (num >= 0);
        }
    }
}
