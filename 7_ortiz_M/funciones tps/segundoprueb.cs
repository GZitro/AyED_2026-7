using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Contador


{
    class Program
    {
        static void Main(string[] args)
        {
            Contador();
        }
        static void Contador()
        {
            int cont = 0;
            int quiere;
            int num;
            Console.Write("cuantos numeros quiere ingresar?");
            quiere = Convert.ToInt32(Console.ReadLine());
            int[] contador = new int[quiere];
            int[] segun = new int[quiere];
            for (int i = 0; i < contador.Length; i++)
            {
                Console.Write("Ingrese un numero:");
                num = Convert.ToInt32(Console.ReadLine());
                contador[i] = num;
            }
            int mayor = contador[0];
            int segundo = contador[0]; 
            foreach (int nume in contador)
            {
                if (nume > mayor)
                {
                   
                    mayor = nume;
                    segun[cont] = mayor;
                     cont++;
                }
            }

            Console.WriteLine("el segundo mayor es:" + segun[0]);


        }

    }
}