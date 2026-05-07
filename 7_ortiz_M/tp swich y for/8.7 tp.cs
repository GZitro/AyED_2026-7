using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese que idioma usa");
            Console.WriteLine("1: Inglés");
            Console.WriteLine("2: Francés");
            Console.WriteLine("3: Alemán");
            int idioma = Convert.ToInt32(Console.ReadLine());


            switch (idioma)
            {
                case 3:
                    Console.WriteLine("Hallo");
                    break;
                case 1:
                    Console.WriteLine("Hello",);
                    break;
                case 2:
                    Console.WriteLine("Salut");
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    break;
            }
        }
    }
}
