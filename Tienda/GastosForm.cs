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
    public partial class GastosForm : Form
    {

        private Finanzas _finanzas;
        public GastosForm()
        {
            InitializeComponent();
        }

        private void GastosForm_Load(object sender, EventArgs e)
        {
            _finanzas = new Finanzas();
            refreshGastos();
        }

        private void modLostBtn_Click(object sender, EventArgs e)
        {
            GastoMain _form = new GastoMain();
            _form.setGastoID(getLostID());
            _form.ShowDialog();
        }
        private int getLostID()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
        }

        private void addLostBtn_Click(object sender, EventArgs e)
        {
            GastoMain _form = new GastoMain();
            _form.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Globals.getSQLCon().openDB();
            Finanzas.DeleteFinance(getLostID());
            Globals.getSQLCon().closeDB();
            Globals.Notify($"Se ha eliminado el gasto con exito!", "Gastos", Notification.alertTypeEnum.Success);
            refreshGastos();
        }

        public void refreshGastos()
        {
            Globals.getSQLCon().openDB();
            dataGridView1.DataSource = _finanzas.getLostsOfDayForm(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Globals.getSQLCon().closeDB();
        }
    }
}
