

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

            int num = Numeromayor();
            int cantidad = 0;

            Console.WriteLine();

            for (int i = 1; i <= num ; i++)
            {
                int suma = 0;
                int repas = i;

              
                while (suma < num)
                {
                    suma += repas;
                    repas++;
                }

                if (suma == num)
                {
                    cantidad++;

                    
                  
                    for (int a = i; a < repas; a++)
                    {
                        Console.Write(a);
                        if (a < repas - 1)
                        {
                            Console.Write("+");
                        }
                    }
                    Console.WriteLine();
                }
            }

            if (cantidad == 1)
            {
                Console.WriteLine("este numero no tiene conseutivos");
            }
          
        }


        static int Numeromayor()
        {

            int num;

            do
            {
                Console.Write("ingrese un numero:");
                num = Convert.ToInt32(Console.ReadLine());


                if (num < 0)
                {

                }


            } while (num <= 0);




            return num;

        }




    }

}


//Desarrollar un programa que permita ingresar un número entero positivo y determinar si puede
//representarse como la suma de dos o más números consecutivos.El programa deberá mostrar
//todas las representaciones posibles encontradas.