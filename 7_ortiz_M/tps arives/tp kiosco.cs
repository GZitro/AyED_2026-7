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

            int billetera;
            int precio;
            int[] kiosco = new int[8];


            for (int i = 0; i < kiosco.Length; i++)
            {

                Console.Write("Ingrese el precio del producto " + (i + 1) + " : ");

                precio = Convert.ToInt32(Console.ReadLine());
               if(precio>0)
                {
                         kiosco[i] = precio;

                }
                  
                
                else
                {
                    Console.WriteLine("Ingrese un monto");
                    i--;
                }
            }
            Console.Write("cuanto dinero tiene para gastar:");
            billetera = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiosco.Length; i++)
            {

                if (kiosco[i] <= billetera)
                {
                    int alcanza = billetera / kiosco[i];

                  
                        Console.WriteLine("puede comprar " + alcanza + " del producto"+(i + 1));
                   
                }
                else
                {
                    Console.WriteLine("no puede comprar el producto"+(i+1));
                }
            }
        }
        }
    }

//Un kiosco tiene 8 productos, cada uno con su precio.El programa debe permitir cargar los 8 precios y luego,
//dado un monto de dinero ingresado por el cliente, indicar cuántos productos distintos podría comprar si el
//objetivo es gastar como máximo ese monto en un solo producto(es decir, cuántos productos tienen un precio
//menor o igual al dinero disponible).