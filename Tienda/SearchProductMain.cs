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
    public partial class SearchProductMain : Form
    {

        private Productos _productos;
        public SearchProductMain()
        {
            InitializeComponent();
        }

        private void SearchProductMain_Load(object sender, EventArgs e)
        {
            _productos = new Productos();
            Globals.getSQLCon().openDB();
            dataGridView1.DataSource = _productos.getProductos();
            Globals.getSQLCon().closeDB();
        }

        private void searchTxt__TextChanged(object sender, EventArgs e)
        {
            _productos.getProductos().DefaultView.RowFilter = "Producto LIKE '%" + searchTxt.Texts + "%' OR Tipo LIKE '%" + searchTxt.Texts + "%'";
        }

        private void backToCheckoutBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(Globals.getCheckout());
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            CheckoutAddProduct _form = new CheckoutAddProduct();
            _form.setProductData(getProductName(), getProductType(), getProductSize(), getProductPrice(), getProductSex());
            _form.ShowDialog();
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

    }
}
