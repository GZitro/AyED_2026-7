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

            Console.WriteLine("ingrese cuantas horas dejo el auto");

            int hora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese cuanto dinero va a pagar");

            int plata = Convert.ToInt32(Console.ReadLine());

        

            if (hora>1)
            {
              int  horaa = 1600 * (hora - 1);
                int total = 4000 + horaa;
               if (total>plata)
                {
                    int falta = total - plata;
                    Console.WriteLine(falta + " falta para pagar");
                }
                else
                {
                    Console.WriteLine(total+ " va a pagar");
                }
            }

            else
            {
                if (4000 > plata)
                {
                    int falta = 4000 - plata;
                    Console.WriteLine(falta + " falta para pagar");
                }
                else
                {
                    Console.WriteLine( " 4000 va a pagar");
                }

            }
        }
    }    }