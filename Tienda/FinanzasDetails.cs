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
    public partial class FinanzasDetails : Form
    {

        private int dia, mes, año, formStyle = 0;
        private Finanzas _finanzas;

        private void FinanzasDetails_Load(object sender, EventArgs e)
        {
            _finanzas = new Finanzas();
            Globals.getSQLCon().openDB();
            if (formStyle.Equals(0))
                dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDay(dia, mes, año);
            else if (formStyle.Equals(1))
                dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(mes, año);
            else if (formStyle.Equals(2))
                dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(año);
            else if (formStyle.Equals(3))
                dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(dia, mes, año);
            Globals.getSQLCon().closeDB();
        }

        private void backToFinanceBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(new FinanzasMain());
        }

        public FinanzasDetails()
        {
            InitializeComponent();
        }

        public void setDataOfDay(int _dia, int _mes, int _año)
        {
            dia = _dia;
            mes = _mes;
            año = _año;
            formStyle = 0;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Globals.Notify($"Se ha eliminado la venta con exito!", "Finanzas", Notification.alertTypeEnum.Success);
                Globals.getSQLCon().openDB();
                Finanzas.DeleteFinanza(getFinanceID());
                if (formStyle.Equals(0))
                    dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDay(dia, mes, año);
                else if (formStyle.Equals(1))
                    dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(mes, año);
                else if (formStyle.Equals(2))
                    dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(año);
                else if (formStyle.Equals(3))
                    dataGridView1.DataSource = _finanzas.getFinancesDetailsOfDate(dia, mes, año);
                Globals.getSQLCon().closeDB();
            }
        }
        private int getFinanceID()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
        }

        public void setDataOfWeek(int _dia, int _mes, int _año)
        {
            dia = _dia;
            mes = _mes;
            año = _año;
            formStyle = 3;
        }
        
        public void setData(int _mes, int _año)
        {
            mes = _mes;
            año = _año;
            formStyle = 1;
        }

        public void setData(int _año)
        {
            año = _año;
            formStyle = 2;
        }

        
    }
}
