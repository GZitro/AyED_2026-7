using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Factorizar


{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            int resultado = Factorizar(num);
            Console.WriteLine(resultado);
        }
        static int Factorizar(int num)
        {
            int sumador = 1;
            int contador = 1;


            while (contador <= num)
            {


                sumador *= contador;


                contador++;

            }
            return sumador;

        }

    }
}
//4. Desarrollar una función llamada Factorial que
//    reciba un número entero mayor o igual a 0 y 
//    retorne su factorial.