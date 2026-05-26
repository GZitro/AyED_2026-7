using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" 1_ Saludar.");
            Console.WriteLine(" 2_ Despedirse");
            Console.WriteLine(" 3_ Salir.");
            int opcion;
            do
            {
                Console.Write("elija la opcion que quiera: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("HOLA MUNDO");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("CHAU MUNDO");

                }
            } while (opcion != 3);
        }
    }
}
