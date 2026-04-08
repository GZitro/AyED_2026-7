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


            Console.Write("cuantos minutos estuvo en el estacionamiento?: ");

            int minutos = Convert.ToInt32(Console.ReadLine());
            int hora = minutos / 60;
            int resto = minutos % 60;
            Console.WriteLine(hora + " hora" + " con " + resto + " minutos estuvo en el estacionamiento");

            int precioh = hora * 6000;
            int preciom = resto * 150;
            int preciof = precioh + preciom;
            Console.WriteLine(preciof + " pesos cuesta el estacionamiento sin iva ");
            int iva = preciof * 21 / 100;
            Console.WriteLine(iva + " pesos (iva)");
            int final = preciof + iva;
            Console.WriteLine(final+ " pesos tendra que pagar");
        }
    }
}
