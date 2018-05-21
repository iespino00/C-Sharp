using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackPila
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList carros = new ArrayList();
            carros.Add("Versa");
            carros.Add("Pointer");
            carros.Add("Mustan");
            carros.Add("Impala");

           for (int i=0; i<carros.Count; i++)
            {
                Console.WriteLine(carros[i]);
            }

            /*
             * PILA- Es una coleccion de elementos, estructura de tipo LIFO (Last in First Out), el ultimo en entrar es el primero en salir
            Puede ser dinámica y puede ser de cualquier tipo, se puede restringir poniendo el tipo de dato por ejemplo
             Stack<String> pilaString = new Stack<String>();
            Existen dos funciones elementales:
             push -> insertar elementos dentro de la pila
             pop  -> devolver el ultimo elemento que se ingreso */

            Stack miPila = new Stack();
            miPila.Push(8);
            miPila.Push(10);
            miPila.Push(20);
            miPila.Push(30);

            int num = 0;

            /*
             Como no se definió un tipo a la pila, si no ponemos (int) marcará error porque puede recibir un string , boolean o cualquier tipo
             entonces con eso nos aseguramos de que será int.
             */
            num = (int)miPila.Pop();

            miPila.Clear();

            Console.WriteLine("El Ultimo valor a insertado en la pila es: {0}",num);
            Console.WriteLine("El número total de elementos de la pila es de: {0}", miPila.Count);

            Console.ReadKey();
        }
    }
}
