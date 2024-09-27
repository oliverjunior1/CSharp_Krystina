using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string textoIngressado = "";

            while (textoIngressado.Equals(""))
            {
                Console.WriteLine("Please, press enter when the alumn enter on the bus. For exit, type some value.");
                textoIngressado = textoIngressado = Console.ReadLine();
                i++;
                Console.WriteLine("Alunos en el bus:{0}", i);
            }
            Console.Read();
        }
    }
}
