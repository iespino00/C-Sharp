using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consutructor
{
    class Principal
    {
        static void Main(String[] args)
        {
            Automovil auto = new Automovil(50000,300);
            Console.ReadKey();
        }

    }



    class Automovil
    {
        //Atributos
        //Modificador de acceso, tipo y nombre
        public int precio;
        public int velocidad;

        //Constructor
        public Automovil(int preci, int velo)
        {
            //Los parámetros que recibo los estoy asignando a los atributos que tengo en la clase
            this.precio = preci;
            this.velocidad = velo;
            Console.WriteLine("El precio del Automóvil es: ${0} y su velocidad es de: {1}Km/h",precio,velocidad);
        //    Console.WriteLine("Se ha creado un objeto de tipo automovil...");
        }


    }
}
