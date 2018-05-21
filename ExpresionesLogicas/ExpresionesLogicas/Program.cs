using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLogicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Logicos
            // Y -> &&
            // O  -> ||
            // NOT -> !

            int a = 1, b = 5;
            bool dia = false;

          
            if (!dia) //Dia se convierte a true y pasa el if, para imprimir dia true
            {
                Console.WriteLine(!dia);
            }
            

            if(a == 0 || b == 0)
            {
                Console.WriteLine("Al menos uno de los valores es 0");
            }
            else
            {
                Console.WriteLine("Ninguno de los valores es cero");
            }

            Console.ReadKey();
        }
    }
}
