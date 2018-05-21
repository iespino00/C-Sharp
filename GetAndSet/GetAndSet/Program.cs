using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Principal
    {
        static void Main(String[] args)
        {
            Automovil auto = new Automovil();
            auto.Velocidad = 500; //Asigno a travez de SET
            Console.WriteLine("La velocidad es: {0}", auto.Velocidad); //Leo a travez de GET
            
            Console.ReadKey();
        }

    }

    class Automovil
    {
        //Atributos
        //Modificador de acceso, tipo y nombre
        public int precio;
        private int velocidad = 100;

        //metodos o funciones
        public int Velocidad  //Para acceder a atributos privados a travez de propiedades de GET y SET
        {
            get  { return velocidad;  }
            set  { velocidad = value; }
        }

    }
}
