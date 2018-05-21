using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Para usar los Array list

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashTable
            //Pila
            //Cola

            //ArrayList -> Un arreglo que guarda info en forma de lista y tiende a cambiar el tamaño segun lo requiera dinámicamente.
            ArrayList carros = new ArrayList();

            carros.Add("Versa");
            carros.Add("Pointer");
            carros.Add("Mustang");
            carros.Add("Impala");

            for(int i = 0; i < carros.Count;i++)
              {
                Console.WriteLine(carros[i]);
            }
         
            Console.ReadKey();
        }
    }
}
