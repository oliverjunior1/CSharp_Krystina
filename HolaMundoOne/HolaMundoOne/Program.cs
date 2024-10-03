using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             // Parsing
            string miString = "15";
            string miSegundoString = "10";

            string resultado = miString + miSegundoString;

            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);

            int resultado2 = num1 + num2;
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado);
            Console.Read();
            */
            // Métodos String
            string nombre = "Joaquim";
            string apellido = "Rodrigues";
            string nombreCompleto = string.Concat("", nombre, apellido, "");
            Console.WriteLine(nombre.Substring(2));
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombreCompleto.Trim());
            Console.Read();
        }
    }
}
