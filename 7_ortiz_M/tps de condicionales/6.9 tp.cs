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

            Console.WriteLine("ingrese su presupuesto");

            int presupuesto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el precio de los materiales ");

            int materiales = Convert.ToInt32(Console.ReadLine());



            


            if (presupuesto >materiales )
            {
                

                Console.WriteLine( "tu presupuesto alcanza");

            }
            if (presupuesto < materiales)
            {
                int diferencia = (materiales-presupuesto) ;

                Console.WriteLine("falta " + diferencia + " pesos para el material");

            }

        }

    }
}


