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
           
            Console.WriteLine("ingrese la nota");

            int nota = Convert.ToInt32(Console.ReadLine());

            


            if (nota>=7)
            {

                Console.WriteLine ( "Promocionado" );



            }
            if (nota >= 4)
            {
                if (nota <= 6)
                {
                    Console.WriteLine("a finales");
                }

            }
                if (nota < 4 )
                {

                    Console.WriteLine("Recuperatorio");



                }

            
           
        }

    }
}
