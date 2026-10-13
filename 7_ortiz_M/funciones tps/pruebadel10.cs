

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Numeromayo


{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = Numeromayor();
            Console.WriteLine("el numero mayor es: " + numero);

        }
        static int Numeromayor()
        {
            int numero;
            int num;
               Console.Write("Ingrese un numero:");
               num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                numero = num / 2;
            }
           
         

          
        return numero;
        }
   
 }
}
//Desarrollar un programa que permita ingresar un número entero positivo y determinar si puede
//representarse como la suma de dos o más números consecutivos.El programa deberá mostrar
//todas las representaciones posibles encontradas.