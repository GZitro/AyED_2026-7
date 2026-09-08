

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Numperfecto


    {
        class Program
        {
            static void Main(string[] args)
            {
            Numperfecto();
            }
            static void Numperfecto()
            {
            int num;
            int contador = 0;
                Console.Write("ingrese un numero positivo: ");
                num = Convert.ToInt32(Console.ReadLine());
               
            
                    if (num>0)
                    {
                for (int i = 1; i <num; i++)
                {
                    if (num % i == 0)
                    {
                        contador = contador + i;
                    }

                }
                if (contador == num)
                {
                    Console.WriteLine("El numero " + num + " es un numero perfecto");
                }
                else
                {
                    Console.WriteLine("El numero " + num + " no es un numero perfecto");
                }



            }
  
                
                

        
                
            }


        }
    }

//Desarrollar un programa que permita ingresar un número entero positivo y determinar si es un
//número perfecto.Un número perfecto es aquel cuya suma de sus divisores positivos menores
//que él mismo es igual al propio número.