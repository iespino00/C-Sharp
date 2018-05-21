using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definicion de una matriz
            // un arreglo de 2 dimensiones

            //Declaración de una matriz
            //tipo de dato + [,] + NombreDeMatriz = + new Tipode dato + [tamaño, tamaño]
            int[,] matriz = new int[3, 3];

          /*
           *       i ,x
           *matriz[0, 0] = 1;
            matriz[0, 1] = 1;
            matriz[0, 2] = 1;

            matriz[1, 0] = 2;
            matriz[1, 1] = 2;
            matriz[1, 2] = 2;

            matriz[2, 0] = 3;
            matriz[2, 1] = 3;
            matriz[2, 2] = 3;*/

            /*For para llenar matriz*/
            for(int i =0; i<3; i++)
            {
                for(int x=0;x<3; x++)
                {
                    matriz[i, x] = 5;
                    Console.WriteLine(matriz[i, x]);
                }
                Console.Write("\n");
            }

           // Console.WriteLine("valor: {0}" , matriz[1, 1]);
            Console.ReadKey();
        }
    }
}
