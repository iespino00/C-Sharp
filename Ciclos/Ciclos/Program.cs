using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciclos son bloques de codigo que se repiten un determinado numero

            //While -> Mientras
            int x = 0;
            while(x<=10)
            { 
            Console.WriteLine("Hello World {0}",x);
                x++;
            }
            Console.ReadKey();
        }
    }
}
