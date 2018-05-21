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

            int[] arreglo = new int[10];




            for(int i=0; i<10; i++)
            {
                arreglo[i] = i+1;
                Console.WriteLine("El valor de la posición {0} es: {1}",i, arreglo[i]);
            }

           
            Console.ReadKey();

        }
    }
}
