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

            Console.WriteLine("ingrese su dinero a la alcancia");
            int plata;
            int alcancia = 0;

            do
            {
                Console.Write("cuanto genero ");
               plata = Convert.ToInt32(Console.ReadLine());
                

                alcancia = alcancia + plata;
               




            } while (plata > 0);


            Console.WriteLine("tu dinero final es " + alcancia);
        }
    }
}

               