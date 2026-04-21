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

                Console.WriteLine("ingrese la cantidad de segundos");

                int segundos = Convert.ToInt32(Console.ReadLine());

            

                if (segundos >= 60)
                {
                int minutos = segundos / 60;
                int resto = segundos % 60;
                Console.WriteLine(minutos + " minutos" + " con " + resto + " segundos");

            }
            if (segundos < 60)
            {
                Console.WriteLine(segundos + " segundos");
            }

            }
        }
    }