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
            Console.WriteLine("elija que comida quiere pedir");
            Console.WriteLine("(S)ándwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa");
            string comida = (Console.ReadLine());


            switch (comida)
            {
                case "S":
                    Console.WriteLine("el sandwich sale 1500");
                    break;
                case "P":
                    Console.WriteLine("la pizza sale 500");
                    break;
                case "H":
                    Console.WriteLine("la hamburguesa esta 2000");
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    break;
            }
        }
    }
}
