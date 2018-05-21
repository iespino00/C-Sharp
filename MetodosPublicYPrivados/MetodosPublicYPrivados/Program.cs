using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicYPrivados
{
    class Principal
    {
        static void Main(String[] args)
        {
            //Objeto automovil
            Automovil auto = new Automovil();
            auto.Velocidad = 500; //Asigno a travez de SET
            Console.WriteLine("La velocidad es: {0}", auto.Velocidad); //Leo a travez de GET

            auto.Suma();
           

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
            get { return velocidad; }
            set { velocidad = value; }
        }

        public void Suma()
        {    
          Console.WriteLine("Suma 2 números A + B es: {0}", calcularSuma(5,6));
        }

        //Los métodos privados solo son accesibles desde la misma clase
        private int calcularSuma(int A, int B)
        {
            int suma = A + B;
            return suma;
        }

    }
}
