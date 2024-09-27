using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Caja
    {
        //Mimbros variables
        private int SuperficieFrontal;
        private int largo;
        private int alto;
        private int ancho;
        private int volumen;

        public Caja(int largo, int alto , int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.Ancho = ancho;
            this.SuperficieFrontal = SuperficieFronatal;
        }
        
        public int SuperficieFronatal { get { return alto * largo; } }

        public int Volumen
        {
            set
            {
                volumen = value;
            }

            get
            {
                return Alto * Ancho * Largo;
            }
        }
        public int Ancho { get; set; }
        public int Alto
        {
            get { return alto; }
            set { if (value < 0) throw new Exception("El tamaño debe ser positivo");
                        alto = value; }
                    
        }
       

        /*
        public int Largo
        {//propiedad auto-implementada
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }
        */
        public int Largo
        {
            get => largo;
            set => largo = value;
        }
        public void MuestraInfo()
        {
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}"
                , largo, alto, Ancho, Volumen = Ancho * alto * largo);
        }
        
    }
}
