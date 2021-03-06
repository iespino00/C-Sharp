﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueCola
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

            for (int i = 0; i < carros.Count; i++)
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

            Console.WriteLine("El Ultimo valor a insertado en la pila es: {0}", num);
            Console.WriteLine("El número total de elementos de la pila es de: {0}", miPila.Count);



            //Queue - Cola
            //FIFO (First In First Out)
            //Metodos
            // enqueue - en fila
            // dequeue

            //Creando Cola o fila
            Queue fila = new Queue();

            //Agregar Elementos
            fila.Enqueue(9);
            fila.Enqueue(15);
            fila.Enqueue(26);

          

            fila.Dequeue(); //Me elimina el primer registro que entró osea 9
            Console.WriteLine(fila.Peek());//Imprimirá 15 ya que fue eliminado el 9 con la linea anterior
            fila.Clear(); //Elimina los elementos que agregamos a la fila.


            /* Hash Table - Estructura dinámica 
              - Add -> Ingresar elementos
            
            */
            Hashtable tabla = new Hashtable();

            //El metodo ADD espera 2 parametros, el primero es el key y el segundo el valor
            tabla.Add("Concha", 2.50);
            tabla.Add("Bolillo", 1.50);
            tabla.Add("Dona de Chocolate", 5.5);

            float valor;

           // valor = (float)tabla["Concha"];

            Console.WriteLine("El costo de la concha es de : ${0} mxn", tabla["Concha"]);
            Console.ReadKey();
        }
    }
}
