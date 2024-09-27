using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    internal class Publicacion
    {
        private static int publicacionID;

        //Propiedades
        protected int ID {  get;  set; }
        protected string Titulo { get; set; }
        protected string Autor {  get; set; }
        protected bool EsPublico {  get; set; }

        public Publicacion() 
        {
            ID = CrearID();
            Titulo = "Mi primera publicación";
            EsPublico = true;
            Autor = 'Juan Perez';
        }
//Construtor parametrizado
    public Publicacion (string Titulo, string Autor, bool EsPublico)
        {
            this.ID = publicacionID;
            this.Titulo = Titulo;
            this.EsPublico = EsPublico;
            this.Autor = Autor;
    //Método para crear ID
    protected int CrearID()
            { return ++publicacionID;  } 
        }
        
    }
}
