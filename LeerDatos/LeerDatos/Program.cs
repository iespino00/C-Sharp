using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir datos a un usuario desde consola.

            string entrada = "";

            Console.WriteLine("Escribe tu Nombre: ");
            entrada = Console.ReadLine();

            Console.WriteLine("Hola: {0} ¿Como te encuentras hoy?" , entrada);
            Console.ReadKey();
        }
    }
}
