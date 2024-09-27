using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5,4,10);

            Console.WriteLine("El volumen es de {0} y el SuperficieFrontal es {1}.", caja.Volumen, caja.SuperficieFronatal);
            caja.MuestraInfo();

            Console.Read();
        }
    }
}
