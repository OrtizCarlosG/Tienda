using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Class;

namespace Tienda
{
    public partial class FinanzasDetailsDate : Form
    {
        public FinanzasDetailsDate()
        {
            InitializeComponent();
        }

        private int formStyle, month, year;
        private DataTable _detalles;
        private Finanzas _finanzas;

        private void FinanzasDetailsDate_Load(object sender, EventArgs e)
        {
            _finanzas = new Finanzas();
            _detalles = new DataTable();
            if (formStyle.Equals(1))
                getDetailsOfDays();
            else
                getDetailsOfMonth();
            dataGridView1.DataSource = _detalles;
        }

        public void setDate(int _month, int _year)
        {
            this.month = _month;
            this.year = _year;
            formStyle = 1;
        }

        public void setDate(int _year)
        {
            this.year = _year;
            formStyle = 2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formStyle.Equals(1))
            {
                FinanzasDetails _form = new FinanzasDetails();
                _form.setDataOfDay(getMonthDay(), month, year);
                Globals.getMenu().openFormInPanel(_form);
            }
           else if (formStyle.Equals(2))
            {
                FinanzasDetailsDate _form = new FinanzasDetailsDate();
                int month = DateTime.ParseExact(getMonthName(), "MMMM", CultureInfo.CurrentCulture).Month;
                _form.setDate(month, year);
                Globals.getMenu().openFormInPanel(_form);
            }
        }

        private string getMonthName()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private int getMonthDay()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
        }

        private void backToFinanceBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(new FinanzasMain());
        }

        private void getDetailsOfDays()
        {
            _detalles.Clear();
            _detalles.Columns.Clear();
            _detalles.Columns.Add("Dia", typeof(int));
            _detalles.Columns.Add("Efectivo", typeof(string));
            _detalles.Columns.Add("Tarjeta", typeof(string));
            _detalles.Columns.Add("CuentaDNI", typeof(string));
            _detalles.Columns.Add("Total", typeof(string));
            for (int i = 1; i < DateTime.DaysInMonth(year, month); i++)
            {
                Globals.getSQLCon().openDB();
                float efectivo = _finanzas.getSellsOfDayEfectivo(i, month, year);
                float tarjeta = _finanzas.getSellsOfDayTarjeta(i, month, year);
                float mercadopago = _finanzas.getSellsOfDayCuentaDNI(i, month, year);
                Globals.getSQLCon().closeDB();
                float total = efectivo + tarjeta + mercadopago;
                if (total > 0)
                {
                    _detalles.Rows.Add(new Object[]{
                            i,
                            $"${efectivo}",
                            $"${tarjeta}",
                            $"${mercadopago}",
                            $"${total}"
                            });
                    _detalles.AcceptChanges();
               }
            }
        }

        private void getDetailsOfMonth()
        {
            _detalles = new DataTable();
            _detalles.Clear();
            _detalles.Columns.Clear();
            _detalles.Columns.Add("Mes", typeof(string));
            _detalles.Columns.Add("Efectivo", typeof(string));
            _detalles.Columns.Add("Tarjeta", typeof(string));
            _detalles.Columns.Add("CuentaDNI", typeof(string));
            _detalles.Columns.Add("Total", typeof(string));
            for (int i = 1; i < 12; i++)
            {
                Globals.getSQLCon().openDB();
                float efectivo = _finanzas.getSellsOfMonthEfectivo(i, year);
                float tarjeta = _finanzas.getSellsOfMonthTarjeta(i, year);
                float mercadopago = _finanzas.getSellsOfMonthDNI(i, year);
                Globals.getSQLCon().closeDB();
                float total = efectivo + tarjeta + mercadopago;
                if (total > 0)
                {
                    _detalles.Rows.Add(new Object[]{
                            $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i).ToUpper()}",
                            $"${efectivo}",
                            $"${tarjeta}",
                            $"${mercadopago}",
                            $"${total}"
                            });
                    _detalles.AcceptChanges();
                }
            }
        }
    }
}
