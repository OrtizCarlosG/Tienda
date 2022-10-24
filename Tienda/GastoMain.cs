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
    public partial class GastoMain : Form
    {
        private Finanzas _finanzas;
        private int gastoID, formStyle = 0;
        public GastoMain()
        {
            InitializeComponent();
        }

        private void guardarGastoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gastoDetalleInput.Texts) || gastoDetalleInput.getTexts().Equals(gastoDetalleInput.PlaceholderText))
            {
                Globals.Notify("No se ha ingresado el detalle del gasto", "Gastos", Notification.alertTypeEnum.Error);
                return;
            }
            if (string.IsNullOrEmpty(gastoAmountInput.Texts) || gastoAmountInput.getTexts().Equals(gastoAmountInput.PlaceholderText))
            {
                Globals.Notify("No se ha ingresado el monto del gasto", "Gastos", Notification.alertTypeEnum.Error);
                return;
            }
            bool success = float.TryParse(gastoAmountInput.Texts, out float monto);
            if (!success)
            {
                Globals.Notify("El monto debe de ser un numero", "Gastos", Notification.alertTypeEnum.Error);
                return;
            }
            Globals.getSQLCon().openDB();
            if(formStyle.Equals(0))
            {
                Finanzas.addNewFinanceDetail(gastoDetalleInput.Texts, "GASTO", float.Parse(gastoAmountInput.Texts), DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, "Ninguno");
                Globals.Notify("Se ha agregado el gasto con exito!", "Gastos", Notification.alertTypeEnum.Success);
            } else if (formStyle.Equals(1))
            {
                Finanzas.UpdateFinanceDetail(gastoID, gastoDetalleInput.Texts, float.Parse(gastoAmountInput.Texts));
                Globals.Notify("Se ha modificado el gasto con exito!", "Gastos", Notification.alertTypeEnum.Success);
            }
            Globals.getSQLCon().closeDB();
            Globals.getGastos().refreshGastos();
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

        private void GastoMain_Load(object sender, EventArgs e)
        {
            _finanzas = new Finanzas();
            if (formStyle.Equals(1))
            {
                guardarGastoBtn.Focus();
                Globals.getSQLCon().openDB();
                string _details = _finanzas.getLostDetailFromID(gastoID);
                float monto = _finanzas.getLostAmountFromID(gastoID);
                Globals.getSQLCon().closeDB();
                gastoDetalleInput.Texts = _details;
                gastoDetalleInput.setTexts(_details);
                gastoAmountInput.Texts = monto.ToString();
                gastoAmountInput.setTexts(monto.ToString());
                gastoDetalleInput.setTexts(_details);
                gastoAmountInput.setTexts(monto.ToString());
                label2.Text = "Cambiar datos de gasto";
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(100, 255, 0, 0);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
            this.Dispose();
        }

        public void setGastoID(int id)
        {
            gastoID = id;
            formStyle = 1;
        }
    }
}
