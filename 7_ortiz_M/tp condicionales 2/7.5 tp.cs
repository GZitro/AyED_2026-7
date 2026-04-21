    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApplication4
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("ingrese su promedio");

                int promedio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la distancia en km de su casa");

            int distancia = Convert.ToInt32(Console.ReadLine());


            if (promedio > 8)
                {

                if (distancia > 50)
                {
                    Console.WriteLine("beca conseguida");
                }
                }
            if (promedio > 8)
            {
                Console.WriteLine("beca conseguida");
            }
            if (distancia > 50)
            {
                Console.WriteLine("beca conseguida");
            }
            else
            {
                Console.WriteLine("beca no conseguida");
            }
        }
        }
    }