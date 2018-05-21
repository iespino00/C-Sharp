using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores lógicos
            // == igualdad
            // != No Igual o diferente
            // < menor que
            // > mayor que
            // >= Mayor o igual
            // <= Menor o igual

            /*
            5 > 4 = true
            10 < 5 = false
            30 >= 30 true
            5 != 8  true */

            Boolean res;

            res = 5 > 4;

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
