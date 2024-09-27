using System;


namespace Clases_Basico
{
    internal class Humano
    {
        //Miembro variable
        public string primerNombre;
        public string apellido;
        public string colorDeOjos;
        public string colorPelo;
        public int edad;
        //construtor por defecto

        public Humano()
        {
            Console.WriteLine("Construtor llamado. Objeto criado.");
        }



        //Miembro construtor parametrizado

        public Humano(string primerNombre, string apellido, string colorDeOjos, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorDeOjos = colorDeOjos;
            this.edad = edad;
        }

        public Humano(string primerNombre, string apellido, string colorDeOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorDeOjos = colorDeOjos;
        }

        public Humano(string primerNombre, string apellido, string colorDeOjos, int edad, string colorPelo)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorDeOjos = colorDeOjos;
            this.edad = edad;
            this.colorPelo = colorPelo;
        }

        public Humano(string primerNombre)
        {
            this.primerNombre = primerNombre;
            
        }


        //Mimbro método
        public void presentarme()
        {
            if(colorDeOjos != null) 
            {
                Console.WriteLine("Hola soy {0} {1}, tengo ojos {2}, {3} años y pelos {4} . ", primerNombre,
                apellido, colorDeOjos, edad, colorPelo);
            }
            else if(colorDeOjos == null && colorPelo == null)
            {
                Console.WriteLine("Hola soy {0} {1},y tengo {2} años . ", primerNombre,
                apellido, edad);
            }
            else if(colorPelo == null && edad == null) 
            {
                Console.WriteLine("Hola soy {0} y {1} ojos {2}. ", primerNombre,
                apellido, colorDeOjos);
            }
        }


    }
}
