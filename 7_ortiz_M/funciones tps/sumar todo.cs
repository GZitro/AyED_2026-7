using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumarHasta

{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());

           
            int resultado = SumarHasta(num);
            Console.WriteLine(resultado);

        }
        static int SumarHasta(int num)
        {
            int sumador = 0;
            int contador = 1;
            
          
            while (contador <= num)
            {


                sumador +=contador;
                
                
                contador++;

            }
            return sumador;

        }

    }
}
//3. Desarrollar una función llamada SumarHasta que reciba un número 
//    entero positivo y retorne la suma de todos los números 
//    desde 1 hasta ese número.
