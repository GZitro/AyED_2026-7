using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Potencia


{
    class Program
    {
        static void Main(string[] args)
        {


            Potencia();

        }
       
        static void Potencia( )
        {
            int bas;
            int poten;
            Console.Write("Ingrese una base:");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese una potencia:");
            poten = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            int resultado = bas;

            while (contador < poten)
            {

                resultado = resultado * bas;

                contador++;
            }
        Console.WriteLine(resultado);

        }

    }
}
//5. Desarrollar una función llamada Potencia 
//    que reciba una base y un exponente mayor o igual a 0 y retorne 
//    el resultado de elevar la base al exponente.
