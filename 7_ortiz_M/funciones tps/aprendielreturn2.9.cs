

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
            int quiere;
            int num;
            Console.Write("cuantos numeros quiere ingresar?");
            quiere = Convert.ToInt32(Console.ReadLine());
            int[] contador = new int[quiere];
            int repite = 0;
            int mayor = 0;
            if (quiere > 0)
            {
                for (int i = 0; i < contador.Length; i++)
                {
                    Console.Write("Ingrese un numero:");
                    num = Convert.ToInt32(Console.ReadLine());
                    contador[i] = num;
                    if (i == 0)
                    {
                        mayor = num;
                        repite = 1;
                    }
                   else if (num > mayor)
                    {
                        mayor = num;
                        repite = 1; 
                    }
                    else if (num == mayor)
                    {
                        repite++; 
                    }
                }
           if (repite > 1)
                        Console.WriteLine("el numero se repite: " + repite );

            }

  return mayor;
        }
    }
}      