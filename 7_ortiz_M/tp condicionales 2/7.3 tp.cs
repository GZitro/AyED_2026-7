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

            Console.WriteLine("ingrese su año de antiguedad");

            int años = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese su salario");

            int salario = Convert.ToInt32(Console.ReadLine());

            if (años > 20)
            {
                int salariof = (salario * 20)/100;
                int salarioff = salario + salariof;

                Console.WriteLine(salarioff);
            }
            if (años < 20)
            {
                int salariof = (salario * 5) / 100;
                int salarioff = salario + salariof;
              
                Console.WriteLine(salarioff);
            }

        }
    }
}