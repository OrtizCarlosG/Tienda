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
    public partial class CheckoutMain : Form
    {

        private Carrito _carrito;
        private Productos _productos;
        private Ventas _ventas;
        private Finanzas _finanzas;
        public CheckoutMain()
        {
            InitializeComponent();
            Globals.setCheckout(this);
        }

        private void CheckoutMain_Load(object sender, EventArgs e)
        {
            _carrito = new Carrito();
            _productos = new Productos();
            _ventas = new Ventas();
            _finanzas = new Finanzas();
            dataGridView1.DataSource = _carrito.getCarrito();
            addProdBtn.Focus();
            searchTxt.Focus();
        }

        public void RefreshPrice()
        {
            totalLbl.Text = $"${_carrito.getTotalPrice()}";
        }
        public void addProductToCheckout(string productName, string productType, string size, float price, string sex, int amount)
        {
            _carrito.insertNewProductInCarrito(productName, productType, size, price, sex, amount);
            totalLbl.Text = $"${_carrito.getTotalPrice()}";
        }

        public void updateProductToCheckout(string productName, string productType, string size, float price, int amount)
        {
            _carrito.updateProductFromCarrito(productName, productType, size, price, amount);
            totalLbl.Text = $"${_carrito.getTotalPrice()}";
        }

        public void updateProductToCheckoutDiscount(string productName, string productType, string size, float price, int amount, int descuento)
        {
            _carrito.updateProductFromCarrito(productName, productType, size, price, amount, descuento);
            totalLbl.Text = $"${_carrito.getTotalPrice()}";
        }


        public void setCheckoutDiscount(int _discount)
        {
            _carrito.setDiscount(_discount);
            totalLbl.Text = $"${_carrito.getTotalPrice()}";
        }

        private void searchProdBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(new SearchProductMain());
        }

        private void modifyProductBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CheckoutAddProduct _form = new CheckoutAddProduct();
                _form.setProductData(getProductName(), getProductType(), getProductSize(), getProductPrice(), getProductSex(), getProductAmount());
                _form.ShowDialog();
            } else
            {
                Globals.Notify($"Seleccione el producto que desea modificar!", "Carrito", Notification.alertTypeEnum.Error);
            }
        }

        private string getProductName()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private string getProductType()
        {
            int i = dataGridView1.SelectedCells[1].RowIndex;
            return dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
        private string getProductSize()
        {
            int i = dataGridView1.SelectedCells[2].RowIndex;
            return dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
        private float getProductPrice()
        {
            int i = dataGridView1.SelectedCells[3].RowIndex;
            return float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
        }
        private string getProductSex()
        {
            int i = dataGridView1.SelectedCells[4].RowIndex;
            return dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private int getProductAmount()
        {
            int i = dataGridView1.SelectedCells[5].RowIndex;
            return Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Globals.Notify($"Se ha eliminado el producto {getProductName()} del carrito", "Carrito", Notification.alertTypeEnum.Error);
                _carrito.deleteProductFromCarrito(getProductName(), getProductType(), getProductSize(), getProductPrice());
                totalLbl.Text = $"${_carrito.getTotalPrice()}";
            }
            else
            {
                Globals.Notify($"Seleccione el producto que desea eliminar!", "Carrito", Notification.alertTypeEnum.Error);
            }
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DiscountMain _form = new DiscountMain();
                _form.setProductData(getProductName(), getProductType(), getProductSize(), getProductPrice(), getProductSex(), getProductAmount(), _carrito.getTotalPrice());
                _form.ShowDialog();
            }
            else
            {
                Globals.Notify($"Seleccione un producto primero!", "Carrito", Notification.alertTypeEnum.Error);
            }
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            Globals.getSQLCon().openDB();
            if (Productos.doesProductCodeExists(searchTxt.Texts))
            {
                string productName = _productos.getProductNameFromCode(searchTxt.Texts);
                string productType = _productos.getProductTypeFromCode(searchTxt.Texts);
                string productSize = _productos.getProductSizeFromCode(searchTxt.Texts);
                float price = _productos.getProductPriceFromCode(searchTxt.Texts);
                string sex = _productos.getProductSexFromCode(searchTxt.Texts);
                CheckoutAddProduct _form = new CheckoutAddProduct();
                _form.setProductData(productName, productType, productSize, price, sex);
                _form.ShowDialog();
                searchTxt.setTexts("");
            }
            Globals.getSQLCon().closeDB();
            searchTxt.Focus();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (_carrito.getCarrito().Rows.Count > 0)
            {
                Checkout _form = new Checkout();
                _form.addCarrito(_carrito);
                _form.ShowDialog();
            }
        }

        private void searchTxt__TextChanged(object sender, EventArgs e)
        {
            Globals.getSQLCon().openDB();
            if (Productos.doesProductRawCodeExists(searchTxt.Texts))
            {
                string productName = _productos.getProductNameFromCode(searchTxt.Texts);
                string productType = _productos.getProductTypeFromCode(searchTxt.Texts);
                string productSize = _productos.getProductSizeFromCode(searchTxt.Texts);
                float price = _productos.getProductPriceFromCode(searchTxt.Texts);
                string sex = _productos.getProductSexFromCode(searchTxt.Texts);
                if (_carrito.getProductAmountInCarrito(productName, productType, productSize, price) + 1 <= _productos.getProductAmount(productName, productType, productSize, price, sex))
                    addProductToCheckout(productName, productType, productSize, price, sex, 1);
                else
                    Globals.Notify($"No hay stock suficiente de este producto", "Carrito", Notification.alertTypeEnum.Error);
                //CheckoutAddProduct _form = new CheckoutAddProduct();
                //_form.setProductData(productName, productType, productSize, price, sex);
                //_form.ShowDialog();
                searchTxt.setTexts("");
            }
            //searchTxt.Texts = "";
            Globals.getSQLCon().closeDB();
        }

        private void productossBtn_Click(object sender, EventArgs e)
        {
            ProductoSSForm _form = new ProductoSSForm();
            _form.ShowDialog();
        }
    }
}
