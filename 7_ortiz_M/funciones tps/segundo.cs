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
            int mayor ;
            int segundo;
           
                if (contador[0] > contador[1])
                {

                mayor = contador[0];
                segundo = contador[1];
            }
            else
            {
                mayor = contador[1];
                segundo = contador[0];

            }
            for (int i = 2; i < contador.Length; i++)
            {
                int nume = contador[i];

                if (nume > mayor)
                {
                    segundo = mayor;
                    mayor = nume;
                }
                 if (nume > segundo && nume != mayor)
                {
                    segundo = nume;
                }
            }
            Console.WriteLine("el segundo mayor es:" + segundo);
        }

       


    }

    }
