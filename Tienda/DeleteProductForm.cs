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
    public partial class DeleteProductForm : Form
    {

        private string productName, productType, productSize, productSex;
        private float price;

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Globals.getSQLCon().openDB();
            Productos.DeleteProduct(productName, productType, productSize, price, productSex, amount);
            Globals.Notify("Se ha eliminado el producto con exito!", "Productos", Notification.alertTypeEnum.Success);
            Globals.getProductsForm().refreshTotalPrice();
            Globals.getSQLCon().closeDB();
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        private int amount;
        public DeleteProductForm()
        {
            InitializeComponent();
        }

        public void setProductData(string _productName, string _productType, string _productSize, string _productSex, float productPrice, int productAmount)
        {
            this.productName = _productName;
            this.productType = _productType;
            this.productSize = _productSize;
            this.productSex = _productSex;
            this.price = productPrice;
            this.amount = productAmount;
        }
    }
}
