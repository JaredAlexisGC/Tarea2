using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class ControlPeliculas
    {
        private Estante _comedia;
        private Estante _scifi;
        private Estante _terror;
        private Estante _romance;
        private Estante _accion;
        private Estante _drama;
        private Estante _otro;

        public ControlPeliculas()
        {
            _comedia = new Estante("Comedia");
            _scifi = new Estante("Ciencia ficcion");
            _terror = new Estante("Terror");
            _romance = new Estante("Romance");
            _accion = new Estante("Accion");
            _drama = new Estante("Drama");
            _otro = new Estante("Otro");
        }

        public void menuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("[1] Buscar pelicula");
                Console.WriteLine("[2] Eliminar pelicula");
                Console.WriteLine("[3] Agregar pelicula");
                Console.WriteLine("[4] Salir");
            } while (!validarMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine("Nombre de pelicula");
                    string nombre = Console.ReadLine();
                    buscarPelicula(nombre);
                    break;
                case 2:
                    Console.WriteLine("Nombre de pelicula");
                    string nombrePelicula = Console.ReadLine();
                    eliminarPelicula(nombrePelicula);
                    break;
                case 3:
                    agregarNuevaPelicula();
                    break;

            }
            if (opcionSeleccionada != 4)
            {
                Console.WriteLine("Pulse enter para continuar...");
                Console.ReadLine();
                menuPrincipal();
            }
        }

        public void agregarNuevaPelicula()
        {
            Console.WriteLine("Nombre de pelicula");
            string nombre = Console.ReadLine();
            Console.WriteLine("Año de estreno");
            int año = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Director");
            string director = Console.ReadLine();
            Console.WriteLine("Genero (Comedia, Ciencia ficcion, Terror, Romance, Accion, Drama, Otro)");
            string genero = Console.ReadLine();
            Console.WriteLine("Formato (Beta, Vhs, Dvd, BlueRay, Otro)");
            string formato = Console.ReadLine();
            Pelicula nuevaPelicula = new Pelicula(nombre, año, director, genero, formato);
            if (genero == "Comedia")
            {
                _comedia.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Ciencia ficcion")
            {
                _scifi.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Terror")
            {
                _terror.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Romance")
            {
                _romance.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Accion")
            {
                _accion.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Drama")
            {
                _drama.agregarPelicula(nuevaPelicula);
            }
            else if (genero == "Otro")
            {
                _otro.agregarPelicula(nuevaPelicula);
            }
            else
            {
                Console.WriteLine("Genero invalido");
            }

        }

        public void eliminarPelicula(string titulo)
        {
            int eliminado = 0;
            if (_comedia.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_scifi.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_terror.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_romance.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_accion.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_drama.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            else if (_otro.eliminar(titulo))
            {
                eliminado = eliminado + 1;
            }
            if (eliminado == 0)
            {
                Console.WriteLine("Pelicula no encontrada");
            }
            else
            {
                Console.WriteLine("Pelicula eliminada");
            }
        }

        public void buscarPelicula(string titulo)
        {
            string estante = "";
            string seccion = _comedia.buscar(titulo);
            if (seccion == "")
            {
                seccion = _scifi.buscar(titulo);
                if (seccion == "")
                {
                    seccion = _terror.buscar(titulo);
                    if (seccion == "")
                    {
                        seccion = _romance.buscar(titulo);
                        if (seccion == "")
                        {
                            seccion = _accion.buscar(titulo);
                            if (seccion == "")
                            {
                                seccion = _drama.buscar(titulo);
                                if (seccion == "")
                                {
                                    seccion = _otro.buscar(titulo);
                                    if (seccion == "")
                                    {
                                        Console.WriteLine("Pelicula no encontrada");
                                    }
                                    else
                                    {
                                        estante = _otro.ToString();
                                    }
                                }
                                else
                                {
                                    estante = _drama.ToString();
                                }
                            }
                            else
                            {
                                estante = _accion.ToString();
                            }
                        }
                        else
                        {
                            estante = _romance.ToString();
                        }
                    }
                    else
                    {
                        estante = _terror.ToString();
                    }
                }
                else
                {
                    estante = _scifi.ToString();
                }
            }
            else
            {
                estante = _comedia.ToString();
            }

            if (estante != "" && seccion != "")
            {
                Console.WriteLine($"La pelicula esta en: Estante: {estante}, Seccion: {seccion}");
                if (estante == "Comedia")
                {
                    _comedia.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Ciencia ficcion")
                {
                    _scifi.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Terror")
                {
                    _terror.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Romance")
                {
                    _romance.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Accion")
                {
                    _accion.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Drama")
                {
                    _drama.obtenerInformacionPelicula(titulo);
                }
                else if (estante == "Otro")
                {
                    _otro.obtenerInformacionPelicula(titulo);
                }

            }
        }

        private Boolean validarMenu(int opciones, ref int opcionesSeleccion)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionesSeleccion = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción invalida");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor invalido, se debe ingresar un número.");
                return false;
            }
        }

        public void inicializarEstantes()
        {
            Pelicula peliculaC1 = new Pelicula("El chanfle", 1979, "Roberto Gomez Bolaños", "Comedia", "Beta");
            Pelicula peliculaC2 = new Pelicula("Space Jam", 1996, "Warner Bros", "Comedia", "Vhs");
            Pelicula peliculaC3 = new Pelicula("Scary Movie", 2001, "Keenen Ivory Waynas", "Comedia", "Dvd");
            Pelicula peliculaC4 = new Pelicula("Y donde estan las rubias", 2004, "Keenen Ivory Waynas", "Comedia", "BlueRay");
            Pelicula peliculaC5 = new Pelicula("Un viernes de locos", 2003, "Mark Waters", "Comedia", "Otro");

            Pelicula peliculaCF1 = new Pelicula("Alien", 1979, "Ridleey Scott", "Ciencia ficcion", "Beta");
            Pelicula peliculaCF2 = new Pelicula("Star Wars", 1977, "Geoge Lucas", "Ciencia ficcion", "Vhs");
            Pelicula peliculaCF3 = new Pelicula("Volver al futuro", 1985, "Robert Zemeckis", "Ciencia ficcion", "Dvd");
            Pelicula peliculaCF4 = new Pelicula("Jurassic Park", 1993, "Steven Spilberg", "Ciencia ficcion", "Dvd");
            Pelicula peliculaCF5 = new Pelicula("Avengers", 2012, "Joss Whedon", "Ciencia ficcion", "BluRay");

            Pelicula peliculaT1 = new Pelicula("Hallowen", 1978, "Jhon Carpenter", "Terror", "Beta");
            Pelicula peliculaT2 = new Pelicula("Chucky", 1988, "Tom Holland", "Terror", "Vhs");
            Pelicula peliculaT3 = new Pelicula("Actividad paranormal", 2007, "Oren Peli", "Terror", "Dvd");

            Pelicula peliculaR1 = new Pelicula("Titanic", 1997, "James Cameron", "Romance", "Vhs");
            Pelicula peliculaR2 = new Pelicula("Quiero comerme tu pancreas", 2016, "Shinchiro Ushijima", "Romance", "BlueRay");
            Pelicula peliculaR3 = new Pelicula("Your Name", 2016, "Makoto Shinkai", "Romance", "Dvd");

            Pelicula peliculaA1 = new Pelicula("Operacion dragon", 1973, "Robert Clouse", "Accion", "Beta");
            Pelicula peliculaA2 = new Pelicula("Matrix", 1999, "Lana Wachowski", "Accion", "Vhs");
            Pelicula peliculaA3 = new Pelicula("Rapidos y furiosos 9", 2021, "Justin Lin", "Accion", "Otro");

            Pelicula peliculaD1 = new Pelicula("El pianista", 2002, "Roman Polanski", "Drama", "Vhs");
            Pelicula peliculaD2 = new Pelicula("Joker", 2019, "Todd Philips", "Drama", "BlueRay");
            Pelicula peliculaD3 = new Pelicula("Nosotros los pobres", 1948, "Ismael Rodriguez", "Drama", "Beta");

            _comedia.agregarPelicula(peliculaC1);
            _comedia.agregarPelicula(peliculaC2);
            _comedia.agregarPelicula(peliculaC3);
            _comedia.agregarPelicula(peliculaC4);
            _comedia.agregarPelicula(peliculaC5);

            _scifi.agregarPelicula(peliculaCF1);
            _scifi.agregarPelicula(peliculaCF2);
            _scifi.agregarPelicula(peliculaCF3);
            _scifi.agregarPelicula(peliculaCF4);
            _scifi.agregarPelicula(peliculaCF5);

            _terror.agregarPelicula(peliculaT1);
            _terror.agregarPelicula(peliculaT2);
            _terror.agregarPelicula(peliculaT3);

            _romance.agregarPelicula(peliculaR1);
            _romance.agregarPelicula(peliculaR2);
            _romance.agregarPelicula(peliculaR3);

            _accion.agregarPelicula(peliculaA1);
            _accion.agregarPelicula(peliculaA2);
            _accion.agregarPelicula(peliculaA3);

            _drama.agregarPelicula(peliculaD1);
            _drama.agregarPelicula(peliculaD2);
            _drama.agregarPelicula(peliculaD3);

        }
    }
}
