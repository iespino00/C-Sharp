using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
namespace JSONexample
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("Name:{0} \n Age:{1}",name, age); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Deserealizando JSON directamente  del Archivo
            String JSONstring = File.ReadAllText("JSON.json");
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);

            Person p2 = new Person { name = "Prueba", age = 30 };
            string outputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", outputJSON);
            Console.ReadKey();
        }
    }
}
