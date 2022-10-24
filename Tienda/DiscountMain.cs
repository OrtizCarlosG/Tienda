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
    public partial class DiscountMain : Form
    {

        private string productName, productType, productSex, productSize;
        private int productAmount;
        private float productPrice, totalPrice;

        private void productRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (productRadio.Checked)
                panel1.Visible = true;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(amountInput.Texts, out int discount);
            if (success)
            {
                if (carritoRadio.Checked)
                {
                    Globals.getCheckout().setCheckoutDiscount(discount);
                    Globals.Notify($"Se ha aplicado un descuento del {discount}% al carrito", "Descuentos", Notification.alertTypeEnum.Info);
                }
                else if (productRadio.Checked)
                {
                    Globals.getCheckout().updateProductToCheckoutDiscount(productName, productType, productSize, productPrice, productAmount, discount);
                    Globals.Notify($"Se ha aplicado un descuento del {discount}% a {productName}", "Descuentos", Notification.alertTypeEnum.Info);
                }
            }
        }

        private void amountInput__TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(amountInput.Texts, out int discount);
            if (success)
            {
                if (carritoRadio.Checked)
                {
                    discountLbl.Text = $"${((totalPrice * discount) / 100)}";
                    totalPriceLbl.Text = $"${totalPrice}";
                    totalLbl.Text = $"${totalPrice - ((totalPrice * discount / 100))}";

                } else if (productRadio.Checked)
                {
                    discountLbl.Text = $"${(productPrice * discount) / 100}";
                    totalPriceLbl.Text = $"${productPrice}";
                    totalLbl.Text = $"${productPrice - ((productPrice * discount)) / 100}";
                }

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        private void carritoRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (carritoRadio.Checked)
                panel1.Visible = true;
        }



        public void setProductData(string _productName, string _productType, string _productSize, float _productPrice, string _productSex, int _productAmount, float _totalPrice)
        {
            productName = _productName;
            productType = _productType;
            productSize = _productSize;
            productPrice = _productPrice;
            productSex = _productSex;
            productAmount = _productAmount;
            totalPrice = _totalPrice;
        }


        public DiscountMain()
        {
            InitializeComponent();
        }


    }
}
