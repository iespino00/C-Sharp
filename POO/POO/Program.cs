using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Principal
    {
        static void Main(String[] args)
        {
            Automovil auto = new Automovil();
            auto.precio = 5000;
            Console.WriteLine("Precio del Auto: {0}", auto.precio);
            auto.arrancar();
            Console.ReadKey();
        }

    }

    class Automovil
    {
        //Atributos
        //Modificador de acceso, tipo y nombre
        public int precio;
        private int velocidad;

        //metodos o funciones
        public void arrancar()
        {
            Console.WriteLine("El Automovil está arrancando...");
        }

        private void acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

    }


}
