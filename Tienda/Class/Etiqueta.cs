using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    class Etiqueta
    {
        private string producto, codigo, talle;
        private float precio;
        public Etiqueta(string _producto, string _codigo, string _talle, float _precio)
        {
            this.producto = _producto;
            this.codigo = _codigo;
            this.talle = _talle;
            this.precio = _precio;
        }

        public string getProducto()
        {
            return this.producto;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public string getTalle()
        {
            return this.talle;
        }

        public float getPrecio()
        {
            return this.precio;
        }
    }
}
