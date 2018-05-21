using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //   definicion de un arreglo
            //  tipo[] nombre = new tipo[tamaño];

            int[] arreglo = new int[4];

            arreglo[0] = 10;
            arreglo[1] = 20;
            arreglo[2] = 30;
            arreglo[3] = 40;

            Console.WriteLine("El valor de la posición 0 es: {0}", arreglo[0]);
            Console.ReadKey();

        }
    }
}
