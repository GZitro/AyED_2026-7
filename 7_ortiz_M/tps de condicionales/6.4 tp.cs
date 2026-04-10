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
           
            Console.WriteLine("ingrese el monto de la compra");

            int precio = Convert.ToInt32(Console.ReadLine());

            


            if (precio>=5000)
            {
                int preciof = precio * 15 / 100;
                int final = preciof + precio;
                Console.WriteLine ( final+ "pesos sale con la promocion" );



            }
            else
            {
                Console.WriteLine(precio + "pesos sale todo");
            }



                }

            
           
        }

    }

