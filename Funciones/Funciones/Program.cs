using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de funciones
            /*
                Ejecutan codigo
                Devuelven valores
                Reciben valores
                Reciben valores y devuelven valores 
             */
            int n = 5;
            mostrarMsn();
            Console.WriteLine(regresaSuma());

            Console.ReadKey();
        }

        //FUNCION QUE EJECUTA UN CODIGO
        //Se pone static porque se ejecuta desde el mismo codigo.
        static void mostrarMsn()
        {
            Console.WriteLine("Funcion de ejecutar codigo");
           
        }

        //funcion que regresa un valor
        //tipo de funcion + tipo de valor a regresar + nombre de funcion + parametros dentro de la funcion
        static int regresaSuma()
        {
            int suma = 9 + 9;
            return suma;
        }

    }
}
