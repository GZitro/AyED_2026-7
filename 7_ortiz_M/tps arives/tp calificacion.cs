using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int satisfaccion;
            int[] encuesta = new int[25];
            int[] lista= new int[5];
            for (int i = 0; i < encuesta.Length; i++)
            {

                Console.Write("Ingrese una calificacion a su atencion del 1 al 5 : ");

                satisfaccion = Convert.ToInt32(Console.ReadLine());
                if (satisfaccion<=5)
                {
                    encuesta[i] = satisfaccion;
                    switch (satisfaccion)
                    {
                        case 1:
                            lista[0] += 1;
                            break;
                        case 2:
                            lista[1] += 1;
                            break;
                        case 3:
                            lista[2] += 1;
                            break;
                        case 4:
                            lista[3] += 1;
                            break;
                        case 5:
                            lista[4] += 1;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un valor entre 1 y 5");
                    i--;
                }
            }
            Console.WriteLine("hubieron " + lista[0] + " personas que votaron 1");
            Console.WriteLine("hubieron " + lista[1] + " personas que votaron 2");
            Console.WriteLine("hubieron " + lista[2] + " personas que votaron 3");
            Console.WriteLine("hubieron " + lista[3] + " personas que votaron 4");
            Console.WriteLine("hubieron " + lista[4] + " personas que votaron 5");
        }
    }
}
