using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    class Principal
    {
        static void Main(String[] args)
        {
            Automovil auto = new Automovil(50000, 300);

            auto.Suma("Ferrari");

            Console.ReadKey();
        }

    }

   class Automovil
    {
        //Atributos
        //Modificador de acceso, tipo y nombre
        public int precio;
        public int velocidad;

        //Sobrecargando el constructor
        public Automovil()
        {
            Console.WriteLine("Se creo un obj SIN parametros");
        }

        //Constructor
        public Automovil(int preci, int velo)
        {
            //Los parámetros que recibo los estoy asignando a los atributos que tengo en la clase
            this.precio = preci;
            this.velocidad = velo;
            Console.WriteLine("Se creo un obj con parametros");
        }

        //Metodos

        public void Suma()
        {
            int suma = precio + velocidad;
            Console.WriteLine("El resultado de la suma es: {0}", suma);
        }

        public void Suma(String nombre)
        {
             int suma = precio + velocidad;
            Console.WriteLine("El resultado de la suma para el auto: {0} es: {1}",nombre, suma);
        }


    }
} 
