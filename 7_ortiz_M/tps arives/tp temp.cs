using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] temperatura = new int[7];
            int contador = 0;
            int mayor = 0;




            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes","sabado","domingo"};
            for (int i = 0; i < temperatura.Length; i++)
            {

                Console.Write("Ingrese la temperaura del dia "+dias[i]+" : ");

                temp = Convert.ToInt32(Console.ReadLine());
                temperatura[i] = temp;
            }
            int menor = temperatura[0];

            foreach (int suma in temperatura)
            {

                contador = contador + suma;
                if (suma > mayor)
                {
                    mayor = suma;
                }
                if (suma < menor)
                {
                    menor = suma;
                }

            }

            int promedio = contador / temperatura.Length;
                Console.WriteLine("el promedio de la semana fue "+promedio);
                Console.WriteLine("la mayor temperatura fue de "+mayor);
                Console.WriteLine("la menor temperatura fue de "+menor);




            //for (int i = 0; i < temperatura.Length; i++)
            //{

            //    Console.WriteLine(temperatura[i]);

            //}









            //Un centro meteorológico registra la temperatura máxima de cada día de la semana(7 valores).El programa
            //debe permitir cargar las 7 temperaturas y luego mostrar: la temperatura más alta de la semana, la más baja, y el
            //promedio semana
        }
        }
    }

