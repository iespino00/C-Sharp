using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    //clase
    class Program
    {
        //Funciones
        static void Main(string[] args)
        {

            //Un espacio de memoria que se define para ser utilizado y almacenar datos
            int numero = 5;
            string texto = "mi cadena";
            bool boleana = false;

            //instrucciones
            //  Console.Write("La variable Entera tiene: {0} y la variable cadena contiene: {1} y la variable booleana contiene: {2}", numero,texto,boleana);
            Console.Write("La variable Entera tiene: {0}",numero);
            Console.Write("La variable string contiene: {0}", texto);
            Console.Write("La variable boleana contiene: {0}", boleana);
            Console.ReadKey();
        }
    }
}
