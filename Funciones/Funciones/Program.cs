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
            mostrarMsn();
            Console.WriteLine(regresaSuma());
            resta(2,1);

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

        //Funcion que recibe un valor

        static void resta(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 - valor2;
            Console.WriteLine("la resta de {0} - {1} es = {2}",valor1,valor2,resultado);
        }

    }
}
