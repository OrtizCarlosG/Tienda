using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Class;

namespace Tienda
{
    public partial class Checkout : Form
    {
        private Carrito _carrito;
        private Productos _productos;
        public Checkout()
        {
            InitializeComponent();
        }


        public void addCarrito(Carrito carrito)
        {
            _carrito = carrito;
        }

        private void finCheckoutBtn_Click(object sender, EventArgs e)
        {
            string tipo = "Efectivo";
            if (tarjetaRadio.Checked)
                tipo = "Tarjeta";
            else if (cuentaDNIRadio.Checked)
                tipo = "Cuenta DNI";
            else if (mercadoPagoRadio.Checked)
                tipo = "MercadoPago";

            Globals.getSQLCon().openDB();
            foreach (DataRow row in _carrito.getCarrito().Rows)
            {
                string _productName = row["Producto"].ToString();
                string _productType = row["Tipo"].ToString();
                string _size = row["Talle"].ToString();
                int discount = int.Parse(row["Descuento"].ToString());
                float productTotalPrice = float.Parse(row["Precio"].ToString()) * int.Parse(row["Cantidad"].ToString());
                float imaginaryPrice = float.Parse(row["Precio"].ToString());
                if (_carrito.getDiscount() > 0)
                {
                    productTotalPrice = float.Parse(row["Precio"].ToString()) * int.Parse(row["Cantidad"].ToString()) - ((productTotalPrice * _carrito.getDiscount()) / 100);
                }
                if (discount > 0)
                    imaginaryPrice = imaginaryPrice + discount;
                string _sex = row["Sexo"].ToString();
                int _amount = int.Parse(row["Cantidad"].ToString());
                int dia = DateTime.Now.Day;
                int mes = DateTime.Now.Month;
                int año = DateTime.Now.Year;
                Ventas.addNewSale(_productName, _productType, _size, float.Parse(Math.Round(productTotalPrice, 2).ToString()), _sex, _amount, dia, mes, año);
                Finanzas.addNewFinanceDetail($"VENTA: {_productName} T: {_size}", "INGRESO", float.Parse(Math.Round(productTotalPrice, 2).ToString()), dia, mes, año, tipo);
                Productos.updateProductStock(_productName, _productType, _size, imaginaryPrice, _sex, _productos.getProductAmount(_productName, _productType, _size, imaginaryPrice, _sex) - _amount);
            }
            Globals.getSQLCon().closeDB();
            Globals.Notify("Se ha completado la venta", "Ventas", Notification.alertTypeEnum.Success);
            _carrito.ClearCarrito();
            _carrito.setDiscount(0);
            Globals.getCheckout().RefreshPrice();
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            _productos = new Productos();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }
    }
}
