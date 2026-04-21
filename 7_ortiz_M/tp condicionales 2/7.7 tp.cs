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

            Console.WriteLine("ingrese un numero");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese un numero");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese un numero");

            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2)
            {
               if (num1>num3)

                Console.WriteLine(num1 + " es mas alto");

            }

            if (num2 > num1)
            {
                if (num2 > num3)

                    Console.WriteLine(num2 + " es mas alto");

            }
            if (num3 > num1)
            {
                if (num3 > num2)

                    Console.WriteLine(num3 + " es mas alto");

            }
        }
    }    }