using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantas facturas se hicieron en el dia?");

            int factura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuantas docenas completos se hicieron?");

            int docenas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuanto es el precio por docena?");

            int precio = Convert.ToInt32(Console.ReadLine());


            int total = precio * docenas;
            int sobrantes = factura-(docenas * 12) ;

            if (sobrantes > 6)
            {
                Console.WriteLine("alerta de exceso de produccion");
            }

            if (sobrantes <= 6)
            {
                Console.WriteLine("produccion eficente");
            }

            Console.WriteLine(sobrantes + " facturas sobran");
            Console.WriteLine(total+ " salen todas las docenas");







        }
    }
}
