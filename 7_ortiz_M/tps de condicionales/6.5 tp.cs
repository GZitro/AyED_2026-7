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
           
            Console.WriteLine("ingrese el nombre de usuario");

            string nombre = (Console.ReadLine());

            Console.WriteLine("ingrese la contraseña");

            string contra = (Console.ReadLine());

         
      

            if (nombre == "admin")
            {

               
                if (contra == "1234")
                {
                    Console.WriteLine("Acceso concedido");
                }


            }
            else
            {
                Console.WriteLine("Error de credenciales");
            }



                }

            
           
        }

    }

