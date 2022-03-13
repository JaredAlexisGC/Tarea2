using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTienda
{
    internal class Producto
    {
        private List<int> _ventas;
        private string _nombre;
        private double _precioPorUnidad;
        private string _categoria;

        public Producto(string nombre, double precioPorUnidad, string categoria)
        {
            this._nombre = nombre;
            this._precioPorUnidad = precioPorUnidad;
            this._categoria = categoria;
            this._ventas = new List<int>();
        }

        public void agregarVentas(int venta)
        {
            _ventas.Add(venta);
        }

        public int unidadesVendidiasTotales()
        {
            int suma = 0;
            foreach (int i in _ventas)
            {
                suma = suma + i;
            }
            return suma;
        }

        public double precioPorUnidad
        {
            get{ return _precioPorUnidad; }
            set{ _precioPorUnidad = value; }
        }

        public string categoria
        {
            get{ return _categoria; }
            set { _categoria = value; }
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
