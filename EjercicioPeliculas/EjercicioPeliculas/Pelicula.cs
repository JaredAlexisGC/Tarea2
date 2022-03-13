using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class Pelicula
    {
        private string _titulo;
        private int _año;
        private string _director;
        private string _genero;
        private string _formato;

        public Pelicula(string titulo, int año, string director, string genero, string formato)
        {
            this._titulo = titulo;
            this._año = año;
            this._director = director;
            this._genero = genero;
            this._formato = formato;
        }

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public int año
        {
            get { return _año; }
            set { _año = value; }
        }

        public string director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public string formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        public override string ToString()
        {
            return $"Pelicula: {this._titulo}";
        }
    }
}
