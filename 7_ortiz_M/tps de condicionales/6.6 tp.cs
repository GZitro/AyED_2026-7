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

            Console.WriteLine("indique la temperatura actual de la montaña");

            int grados = Convert.ToInt32(Console.ReadLine());






            if (grados > 15)
            {

                Console.WriteLine("clima agradable");

            }
            if (grados > 0)
            {
                if (grados <= 15)
                {
                    Console.WriteLine("mucho frio");
                }
  
                        
                        
              }

            if (grados < 0)
            {

                Console.WriteLine("peligro de congelamiento");

            }

        }



    }

}


