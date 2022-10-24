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
    public partial class ProductoSSForm : Form
    {
        public ProductoSSForm()
        {
            InitializeComponent();
        }

        private void ProductoSSForm_Load(object sender, EventArgs e)
        {

        }

        private void cantidadTxt__TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            bool floatSucess = float.TryParse(priceTxt.Texts, out float result);
            if (floatSucess)
            {
                bool success = int.TryParse(cantidadTxt.Texts, out int amount);
                if (success)
                {
                    totalPriceLbl.Text = $"${amount * result}";
                }
                else
                {
                    totalPriceLbl.Text = $"$0";
                }
            } else
            {
                totalPriceLbl.Text = $"$0";
            }
        }

        private void priceTxt__TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            bool floatSucess = float.TryParse(priceTxt.Texts, out float result);
            if (floatSucess)
            {
                bool success = int.TryParse(cantidadTxt.Texts, out int amount);
                if (success)
                {
                    Globals.getCheckout().addProductToCheckout(productoNameTxt.Texts, "-", "-", result, "-", amount);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }
    }
}
