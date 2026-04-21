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

            Console.WriteLine("ingrese su saldo");

            int saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el monto que quiera retirar");

            int monto = Convert.ToInt32(Console.ReadLine());


            if (monto > saldo)
            {


                Console.WriteLine("saldo insuficiente");

            }

            if (saldo % 1000 == 0)
            {
                Console.WriteLine("solo billetes de mil");
            }

        }
    }    }