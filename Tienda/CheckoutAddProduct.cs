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
    public partial class CheckoutAddProduct : Form
    {

        private string productName, productType, productSex, productSize;
        private int productAmount, formStyle = 0;
        private float productPrice, totalPrice;
        private Productos _productos;


        private void CheckoutAddProduct_Load(object sender, EventArgs e)
        {
            _productos = new Productos();
            productNameLbl.Text = productName;
            productTypeLbl.Text = productType;
            productSizeLbl.Text = productSize.ToString();
            productPriceLbl.Text = $"${productPrice}";
            productSexLbl.Text = productSex;
            addProdBtn.Focus();
            if (formStyle.Equals(1))
            {
                amountInput.Texts = productAmount.ToString();
                calculateTotalPrice();
            }
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(amountInput.Texts, out int amount);
            if (success)
            {
                if (amount > 0)
                {
                    if (formStyle.Equals(0))
                    {
                        Globals.getCheckout().addProductToCheckout(productName, productType, productSize, productPrice, productSex, amount);
                        Globals.Notify($"Se ha añadido {productName} al carrito", "Carrito", Notification.alertTypeEnum.Success);
                    }
                    else
                    {
                        Globals.getCheckout().updateProductToCheckout(productName, productType, productSize, productPrice, amount);
                        Globals.Notify($"Se ha modificado {productName} en el carrito", "Carrito", Notification.alertTypeEnum.Info);
                    }
                    GC.Collect();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    Globals.Notify($"No se ha ingresado una cantidad valida", "Carrito", Notification.alertTypeEnum.Error);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        private void amountInput__TextChanged(object sender, EventArgs e)
        {
            calculateTotalPrice();
            bool success = int.TryParse(amountInput.Texts, out int amount);
            if (success)
            {
                Globals.getSQLCon().openDB();
                int pamount = 0;
                if (Productos.doesProductExists(productName, productType))
                    pamount = _productos.getProductAmount(productName, productType, productSize, productPrice, productSex);
                else
                    pamount = 9999;
                Globals.getSQLCon().closeDB();
                if (pamount < amount)
                {
                    Globals.Notify($"No hay stock suficiente", "Carrito", Notification.alertTypeEnum.Info);
                    amountInput.setTexts($"{pamount}");
                }
            }
        }

        private void calculateTotalPrice()
        {
            bool success = int.TryParse(amountInput.Texts, out int amount);
            if (success)
            {
                totalPriceLbl.Text = $"${amount * productPrice}";
                totalPrice = amount * productPrice;
            }
        }

        public CheckoutAddProduct()
        {
            InitializeComponent();
        }

        public void setProductData(string _productName, string _productType, string _productSize, float _productPrice, string _productSex)
        {
            productName = _productName;
            productType = _productType;
            productSize = _productSize;
            productPrice = _productPrice;
            productSex = _productSex;
            formStyle = 0;
        }

        public void setProductData(string _productName, string _productType, string _productSize, float _productPrice, string _productSex, int _amount)
        {
            productName = _productName;
            productType = _productType;
            productSize = _productSize;
            productPrice = _productPrice;
            productSex = _productSex;
            productAmount = _amount;
            formStyle = 1;
        }
    }
}
