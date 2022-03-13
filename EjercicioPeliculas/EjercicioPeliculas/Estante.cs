using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class Estante
    {
        private string _nombreEstante;
        private List<Pelicula> _seccionBeta;
        private List<Pelicula> _seccionVhs;
        private List<Pelicula> _seccionDvd;
        private List<Pelicula> _seccionBlueRay;
        private List<Pelicula> _seccionOtro;

        public Estante(string nombreEstante)
        {
            _nombreEstante = nombreEstante;
            _seccionBeta = new List<Pelicula>();
            _seccionVhs = new List<Pelicula>();
            _seccionDvd = new List<Pelicula>();
            _seccionBlueRay = new List<Pelicula>();
            _seccionOtro = new List<Pelicula>();
        }

        public void agregarPelicula(Pelicula pelicula)
        {
            string formatoPelicula = pelicula.formato;
            if (formatoPelicula == "Beta")
            {
                _seccionBeta.Add(pelicula);
                Console.WriteLine("Pelicula agregada");
            }
            else if (formatoPelicula == "Vhs")
            {
                _seccionVhs.Add(pelicula);
                Console.WriteLine("Pelicula agregada");
            }
            else if (formatoPelicula == "Dvd")
            {
                _seccionDvd.Add(pelicula);
                Console.WriteLine("Pelicula agregada");
            }
            else if (formatoPelicula == "BlueRay")
            {
                _seccionBlueRay.Add(pelicula);
                Console.WriteLine("Pelicula agregada");
            }
            else if (formatoPelicula == "Otro")
            {
                _seccionOtro.Add(pelicula);
                Console.WriteLine("Pelicula agregada");
            }
            else
            {
                Console.WriteLine("Formato desconocido");
            }
        }

        public Boolean eliminar(string nombrePelicula)
        {
            int eliminado = 0;
            foreach (Pelicula pelicula in _seccionBeta)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    _seccionBeta.Remove(pelicula);
                    eliminado = eliminado + 1;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionVhs)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    _seccionVhs.Remove(pelicula);
                    eliminado = eliminado + 1;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionDvd)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    _seccionDvd.Remove(pelicula);
                    eliminado = eliminado + 1;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionBlueRay)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    _seccionBlueRay.Remove(pelicula);
                    eliminado = eliminado + 1;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionOtro)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    _seccionOtro.Remove(pelicula);
                    eliminado = eliminado + 1;
                    break;
                }
            }
            if (eliminado == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string buscar(string nombrePelicula)
        {
            string seccion = "";
            foreach (Pelicula pelicula in _seccionBeta)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    seccion = "Beta";
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionVhs)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    seccion = "Vhs";
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionDvd)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    seccion = "Dvd";
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionBlueRay)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    seccion = "BlueRay";
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionOtro)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    seccion = "Otros";
                    break;
                }
            }
            return seccion;
        }

        public void obtenerInformacionPelicula(string nombrePelicula)
        {
            Pelicula? peliculaBuscada = null;
            foreach (Pelicula pelicula in _seccionBeta)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    peliculaBuscada = pelicula;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionVhs)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    peliculaBuscada = pelicula;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionDvd)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    peliculaBuscada = pelicula;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionBlueRay)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    peliculaBuscada = pelicula;
                    break;
                }
            }
            foreach (Pelicula pelicula in _seccionOtro)
            {
                if (pelicula.titulo == nombrePelicula)
                {
                    peliculaBuscada = pelicula;
                    break;
                }
            }

            if (peliculaBuscada != null)
            {
                Console.WriteLine("Titulo: " + peliculaBuscada.titulo);
                Console.WriteLine("Año: " + peliculaBuscada.año);
                Console.WriteLine("Director: " + peliculaBuscada.director);
                Console.WriteLine("Genero: " + peliculaBuscada.genero);
                Console.WriteLine("Formato: " + peliculaBuscada.formato);
            }
        }

        public override string ToString()
        {
            return this._nombreEstante;
        }
    }
}
