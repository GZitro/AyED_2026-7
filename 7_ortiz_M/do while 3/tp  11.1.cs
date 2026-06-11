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
            int valor;
            int suma = 0;
            int contador = 0;
            do
            {
                Console.Write("introduzca el valor de su compra: ");
                valor = Convert.ToInt32(Console.ReadLine());
                contador++;
                suma = valor + suma;




            } while (valor != 0);

            if (suma > 15000)
            {
                int porcen = suma * 10 / 100;
                suma = suma - porcen;
                Console.WriteLine("tiene un descuento, va a tener q pagar " + suma);
            }
            else
            {
                Console.WriteLine("va a tener q pagar " + suma);
            }
        }
    }
}
