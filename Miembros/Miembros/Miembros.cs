using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    internal class Miembros
    {
        //Miembros - Campos privados
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //Miembros - Campo Publico
        public int edad;

        //Miembros - Propiedad
        public string TituloTrabajo
        {   get
            {
                return tituloTrabajo;
            } 
            
            set
            {
                tituloTrabajo = value;
            }
        }
        //Miembro - Metodo privado
        private void CompartirInfoPrivado()
        {
            Console.WriteLine("Hola, mi salario es {0}", salario);
        }

        //Miembros - Metodos Publicos
        public void Amigo(bool esAmigo)
        {
            if(esAmigo)
            { 
                CompartirInfoPrivado();
            }
            else
            {
                Console.WriteLine("Hola, mi nombre es {0}, y mi edad es {1}", nombrePersona, edad);
            }

        }
        //Miembros - Constructor
        public Miembros()
        {
            edad = 30;
            nombrePersona = "Ana";
            salario = 50000;
            tituloTrabajo = "Desarrolador";
            Console.WriteLine("Objeto Creado");
        }
        //Miembros - Finalizador/Destructor

        ~Miembros()
        {
            //Limpia declaraciones
            Console.WriteLine("Destruicion de objeto Miembro.");
            Debug.Write("Destruction de objeto miembro.");
        }

    }
}
