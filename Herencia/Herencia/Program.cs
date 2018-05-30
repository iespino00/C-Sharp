using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Principal
    {
        static void Main(String[] args)
        {
            Automovil auto = new Automovil();
            auto.muestraPrecio();

           Console.ReadKey();
        }

    }

    class Transporte
    {
        protected int numeroPasajeros;
        protected int precio;
        String nombre;

    }

    //con : hacemos la herencia de Transporte
    class Automovil: Transporte
    {

        //Para poder utilizar una variable que no esta definida en la clase hijo pero si en la Padre
        //usandos protected en los atributos de la clase principal

        public void muestraPrecio()
          {
            precio = 50;
            Console.WriteLine("El precio de este automovil es: {0}", precio);
          }
     
    }

    class Avion:Transporte
    {

    }
}
