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
            Console.Write("cuantos droides vas a comprar?: ");

            int droides = Convert.ToInt32(Console.ReadLine());




            int cantidad = droides * 2000;
            
                if (cantidad >= 6000)
            {
                int iva = cantidad * 20 / 100;
                int preciof = cantidad-iva;
                Console.WriteLine(iva+ " descuento");
                Console.WriteLine(preciof + " precio final");
            }
          
            else
            {
                Console.WriteLine(cantidad + " precio final");
               
            }
        }

    }
}

        