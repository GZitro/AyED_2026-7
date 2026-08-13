using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos;
            int[] tiempos = new int[6];
            
            int mayor = 0;
            




            for (int i = 0; i < tiempos.Length; i++)
            {

                Console.Write("Ingrese el tiempo del corredor N°" + (i + 1) + " : ");
                segundos = Convert.ToInt32(Console.ReadLine());
                tiempos[i] = segundos;



            }
            int menor = tiempos[0];
            foreach (int temp in tiempos)
            {

   
                if (temp > mayor)
                {
                    mayor = temp;
                }
                if (temp < menor)
                {
                    menor = temp;
                }

            }
            Console.WriteLine("el tiempo del ganador fue " + menor+" segundos");
            Console.WriteLine("el peor tiempo fue " + mayor+" segundos");
        

        }
    }
}
