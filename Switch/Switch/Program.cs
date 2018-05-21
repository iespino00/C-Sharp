using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 4;

            switch(valor)
            {
                case 0:
                    Console.WriteLine("Entro al case 0 con valor:  {0}", valor);
                break;

                case 1:
                    Console.WriteLine("Entro al case 1 con valor:  {0}", valor);
                break;

                case 2:
                    Console.WriteLine("Entro al case 2 con valor:  {0}", valor);
                break;

                default:
                    Console.WriteLine("Entro al case Default");
                    break;
            }
            Console.ReadKey();
        }
    }
}
