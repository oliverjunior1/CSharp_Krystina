using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            //primera manera de crear Arrays
            int[] calificaciones = new int[5];

            calificaciones[0] = 10;
            calificaciones[1] = 7;
            calificaciones[2] = 9;
            calificaciones[3] = 3;
            calificaciones[4] = 7;

            string ingresso = Console.ReadLine();
            calificaciones[0] = int.Parse(ingresso);
            Console.WriteLine("Primera calificación {0}", calificaciones[0]);
            
            //segunda manera de crear Arrays
            int[] edades = { 17, 15, 16, 15, 17 };

            //tercera manera
            int[] faltaColegio = new int[] { 3, 5, 7, 3, 4, 5};

            Console.WriteLine("El colegio tien {0} casos de falta.", faltaColegio.Length);
            Console.Read();
        }
    }
}
