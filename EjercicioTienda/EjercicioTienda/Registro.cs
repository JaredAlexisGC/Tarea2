using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTienda
{
    internal class Registro
    {
        private List<Producto> listaProductos;
        private Producto productoPrimerLugar;
        private Producto productoSegundoLugar;
        private Producto productoTercerLugar;

        public Registro()
        {
            this.listaProductos = new List<Producto>();
            productoPrimerLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            productoSegundoLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            productoTercerLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            actualizarMasPopulares();

        }

        public void menuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("[1] Registrar ventas del dia");
                Console.WriteLine("[2] Ver top 3 productos mas vendidios");
                Console.WriteLine("[3] Ver lista de productos");
                Console.WriteLine("[4] Agregar nuevo producto");
                Console.WriteLine("[5] Salir");
            } while (!validarMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    registrarVentasDelDia();
                    break;
                case 2:
                    verTopTres();
                    break;
                case 3:
                    verListaDeProductos();
                    break;
                case 4:
                    agregarProducto();
                    break;
            }
            if (opcionSeleccionada != 5)
            {
                menuPrincipal();
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

        public void actualizarMasPopulares()
        {
            productoPrimerLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            productoSegundoLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            productoTercerLugar = new Producto("Ningun producto", 0.0, "Ninguno");
            foreach (Producto p in listaProductos)
            {
                if (p.unidadesVendidiasTotales() > productoPrimerLugar.unidadesVendidiasTotales())
                {
                    productoPrimerLugar = p;
                }
            }
            foreach (Producto p in listaProductos)
            {
                if (p.unidadesVendidiasTotales() > productoSegundoLugar.unidadesVendidiasTotales() && p!=productoPrimerLugar)
                {
                    productoSegundoLugar = p;
                }
            }
            foreach (Producto p in listaProductos)
            {
                if (p.unidadesVendidiasTotales() > productoTercerLugar.unidadesVendidiasTotales() && p!=productoSegundoLugar && p != productoPrimerLugar)
                {
                    productoTercerLugar = p;
                }
            }
        }

        public void registrarVentasDelDia()
        {
            foreach (Producto p in listaProductos)
            {
                String nombreProducto = p.ToString();
                Console.WriteLine($"Unidedes vendidas de: {nombreProducto}");
                int ventas = Int32.Parse(Console.ReadLine());
                p.agregarVentas(ventas);
            }
            Console.WriteLine("Ventas registradas");
            actualizarMasPopulares();
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
        }

        public void verTopTres()
        {
            string uno = productoPrimerLugar.ToString();
            string dos = productoSegundoLugar.ToString();
            string tres = productoTercerLugar.ToString();
            Console.WriteLine("Productos mas vendidios");
            Console.WriteLine($"1.- {uno}");
            Console.WriteLine($"2.- {dos}");
            Console.WriteLine($"3.- {tres}");
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
        }

        public void agregarProducto()
        {
            Console.WriteLine("Nombre producto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Categoria:");
            string categoria = Console.ReadLine();
            Console.WriteLine("Precio por unidad:");
            double precio = double.Parse(Console.ReadLine());
            Producto nuevoProducto = new Producto(nombre, precio, categoria);
            listaProductos.Add(nuevoProducto);
            Console.WriteLine("Producto agregado");
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
        }

        public void verListaDeProductos()
        {
            Console.WriteLine("Nombre              Categoria           Precio");
            Console.WriteLine("-----------------------------------------------");
            foreach (Producto p in listaProductos)
            {
                string nombre = p.ToString();
                while(nombre.Length < 20)
                {
                    nombre = nombre + " ";
                }
                string categoriaProducto = p.categoria;
                while (categoriaProducto.Length < 20)
                {
                    categoriaProducto = categoriaProducto + " ";
                }
                Console.WriteLine(nombre+ categoriaProducto+ "$"+p.precioPorUnidad);
            }
            Console.WriteLine("Pulse enter para continuar...");
            Console.ReadLine();
        }

        public void inicializarProductos()
        {
            Producto producto1 = new Producto("Suavitel", 19.0, "Lavado");
            Producto producto2 = new Producto("Fabuloso", 15.0, "Limpieza");
            Producto producto3 = new Producto("Salvo", 17.0, "Limpieza");
            Producto producto4 = new Producto("Vanish", 25.0, "Lavado");
            Producto producto5 = new Producto("Escoba", 30.0, "Limpieza");
            Producto producto6 = new Producto("Trapo", 6.0, "Limpieza");
            Producto producto7 = new Producto("Pinol", 17.0, "Limpieza");
            Producto producto8 = new Producto("Trapiador", 32.0, "Limpieza");

            producto1.agregarVentas(2);
            producto2.agregarVentas(3);
            producto3.agregarVentas(4);
            producto4.agregarVentas(1);
            producto5.agregarVentas(7);
            producto6.agregarVentas(8);
            producto7.agregarVentas(6);
            producto8.agregarVentas(5);

            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);
            listaProductos.Add(producto4);
            listaProductos.Add(producto5);
            listaProductos.Add(producto6);
            listaProductos.Add(producto7);
            listaProductos.Add(producto8);
            actualizarMasPopulares();
        }
    }
}
