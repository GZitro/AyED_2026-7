

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
            int sumador = 0;
            int num;
            int pares = 0;
            int impares =0 ;
            int contador = 0;
            Console.Write("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num > num2)
            {
                for (int i = num2; i <= num; i++)
                {
                    contador++;
                    Console.WriteLine(i);
                    if (i % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                    sumador = sumador + i;
                }
            }
            if (num < num2)
            {           
                for (int i =num; i <=num2; i++)
                {
                    contador++;
                    Console.WriteLine(i);
                    if (i % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }               
                    sumador = sumador + i;
                }
            }
            Console.WriteLine("numeros pare: "+pares);
            Console.WriteLine("numeros impares: "+impares);
            Console.WriteLine("la suma de todos los numeros es: "+sumador);
            Console.WriteLine("cuantos numero hubieron: "+contador);
        }
    }
}

//Desarrollar un programa que permita ingresar dos números enteros y mostrar todos los números
//comprendidos entre ambos.Además, informar la cantidad de números pares, la cantidad de
//números impares y la suma de todos los valores mostrados.
