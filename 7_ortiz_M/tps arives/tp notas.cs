using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nt;
            int[] notas = new int[10];
            int contador = 0;
            int aprob = 0;
            int desaprob = 0;



         
            for (int i = 0; i < notas.Length; i++)
            {

                Console.Write("Ingrese la nota de los alumnos " + (i+1) + " : ");

                nt = Convert.ToInt32(Console.ReadLine());
                if (nt < 10)
                {
               notas[i] = nt;
                }
               else
                {
                    Console.WriteLine("Ingrese un valor menor a 10");
                    i--;
                }
            }






            foreach (int suma in notas)
            {
                contador = contador + suma;
                if (suma>=6)
                {
                    aprob++;
                }
                else
                {
                    desaprob++;
                }
            }

            double promedio = contador / notas.Length;
            Console.WriteLine("el promedio de las notas es: " + promedio);
            Console.WriteLine("aprobaron: " + aprob);
            Console.WriteLine("desaprobaron: " + desaprob);


            //for (int i = 0; i < temperatura.Length; i++)
            //{

            //    Console.WriteLine(temperatura[i]);

            //}




            //Un docente tiene un curso de 10 alumnos.El programa debe permitir cargar las 10 notas(valores de 1 a 10) y
            //luego mostrar cuántos alumnos aprobaron (nota mayor o igual a 6), cuántos desaprobaron, y el promedio
            //general del curso.


        }
    }
}


