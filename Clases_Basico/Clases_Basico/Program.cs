using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Crea un objeto desde mi clase.
            //Una Instancia de un humano.
            Humano juan = new Humano("Juan", "Baptist", "azules", 28);
            //acceder a uma variable publica externa
            
            //Llama a un metodo 
            juan.presentarme();

            Humano pedro = new Humano("Pedro", "Rodrigues", "azules", 38);
            
            pedro.presentarme();
            */
            Humano humanoBasico = new Humano("Alberto", "Jaime", "marrons");

            humanoBasico.presentarme();

            Humano humanoIncrement = new Humano("Joaquim", "Rodrigues", "marrons", 40, "marrons");

            humanoIncrement.presentarme();

            Console.Read();

        }
    }
}

