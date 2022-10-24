using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    public class Carrito
    {

        private  DataTable _carrito;
        private int _discount;

        public Carrito()
        {
            _discount = 0;
            _carrito = new DataTable();
            _carrito.Columns.Add("Producto", typeof(String));
            _carrito.Columns.Add("Tipo", typeof(String));
            _carrito.Columns.Add("Talle", typeof(String));
            _carrito.Columns.Add("Precio", typeof(float));
            _carrito.Columns.Add("Sexo", typeof(String));
            _carrito.Columns.Add("Cantidad", typeof(Int32));
            _carrito.Columns.Add("Descuento", typeof(Int32));
        }

        public void ClearCarrito()
        {
            _carrito.Clear();
        }

        public DataTable getCarrito()
        {
            return _carrito;
        }

        public void insertNewProductInCarrito(string producto, string tipo, string talle, float precio, string sexo, int cantidad)
        {
            _carrito.AcceptChanges();
            DataRow dr = _carrito.Select("Producto = '" + producto + "' AND Tipo = '" + tipo + "' AND Talle = '" + talle + "' AND Precio = '"+ precio +"'").FirstOrDefault();
            if (dr != null)
            {
                dr["Precio"] = precio;
                dr["Cantidad"] = cantidad + int.Parse(dr["Cantidad"].ToString());
            }
            else
            {
                _carrito.Rows.Add(new Object[]{
                producto,
                tipo,
                talle,
                precio,
                sexo,
                cantidad,
                0
           });
            }
            _carrito.AcceptChanges();
        }

        public void updateProductFromCarrito(string producto, string productType, string size, float price, int cantidad)
        {
            _carrito.AcceptChanges();
            DataRow dr = _carrito.Select("Producto = '" + producto + "' AND Tipo = '" + productType + "' AND Talle = '"+ size +"' AND Precio = '"+ price +"'").FirstOrDefault();
            if (dr != null)
            {
                dr["Precio"] = price;
                dr["Cantidad"] = cantidad;
            }
            _carrito.AcceptChanges();
        }


        public void updateProductFromCarrito(string producto, string productType, string size, float price, int cantidad, int descuento)
        {
            _carrito.AcceptChanges();
            DataRow dr = _carrito.Select("Producto = '" + producto + "' AND Tipo = '" + productType + "' AND Talle = '" + size + "' AND Precio = '" + price + "'").FirstOrDefault();
            if (dr != null)
            {
                dr["Precio"] = price - (price * descuento / 100);
                dr["Descuento"] = (price * descuento / 100);
                dr["Cantidad"] = cantidad;
            }
            _carrito.AcceptChanges();
        }

        public int getProductAmountInCarrito(string producto, string productType, string size, float price)
        {
            int amount = 0;
            DataRow dr = _carrito.Select("Producto = '" + producto + "' AND Tipo = '" + productType + "' AND Talle = '" + size + "' AND Precio = '"+ price +"'").FirstOrDefault();
            if (dr != null)
            {
                amount = int.Parse(dr["Cantidad"].ToString());
            }
            _carrito.AcceptChanges();
            return amount;
        }


        public float getTotalPrice()
        {
            float precio = 0;
            foreach (DataRow row in _carrito.Rows)
            {
                float productTotalPrice = float.Parse(row["Precio"].ToString()) * int.Parse(row["Cantidad"].ToString());
               //if (int.Parse(row["Descuento"].ToString()) > 0)
               //    precio = precio + (productTotalPrice - (productTotalPrice * int.Parse(row["Descuento"].ToString()) / 100));
               //else
                    precio = precio + productTotalPrice;

            }
            if (_discount > 0)
                return precio - ((precio * _discount) / 100);
            else
                return precio;
        }

        public void setDiscount(int discount)
        {
            _discount = discount;
        }


        public int getDiscount()
        {
            return this._discount;
        }


        public void deleteProductFromCarrito(string producto, string tipo, string talle, float price)
        {
            _carrito.AcceptChanges();
            DataRow[] rows;
            rows = _carrito.Select("Producto = '" + producto + "' AND Tipo = '" + tipo + "' AND Talle = '"+ talle +"' AND Precio = '"+ price +"'");
            foreach (DataRow row in rows)
                _carrito.Rows.Remove(row);
            _carrito.AcceptChanges();
        }
    }
}
