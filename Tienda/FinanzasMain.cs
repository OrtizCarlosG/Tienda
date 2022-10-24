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
    public partial class FinanzasMain : Form
    {

        private Finanzas _finanzas;
        public FinanzasMain()
        {
            InitializeComponent();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            FinanzasDetails _form = new FinanzasDetails();
            _form.setDataOfDay(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Globals.getMenu().openFormInPanel(_form);
        }

        private void FinanzasMain_Load(object sender, EventArgs e)
        {
            _finanzas = new Finanzas();
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            Globals.getSQLCon().openDB();
            float ingresoDia = _finanzas.getSellsOfDayEfectivo(dia, mes, año);
            float ingresoDiaTarjeta = _finanzas.getSellsOfDayTarjeta(dia, mes, año);
            float ingresoDiaCuentaDNI = _finanzas.getSellsOfDayCuentaDNI(dia, mes, año);
            float ingresoDiaMercadoPago = _finanzas.getSellsOfDayMercadoPago(dia, mes, año);
            float gastoDia = _finanzas.getLostsOfDay(dia, mes, año);
            float ingresoSemanal = _finanzas.getSellsOfWeek(dia, mes, año);
            float ingresoSemanalTarjeta = _finanzas.getSellsOfWeekTarjeta(dia, mes, año);
            float ingresoSemanalCuentaDNI = _finanzas.getSellsOfWeekDNI(dia, mes, año);
            float ingresoSemanalMercadoPago = _finanzas.getSellsOfDayMercadoPago(dia, mes, año);
            float gastoSemanal = _finanzas.getLostsOfWeek(dia, mes, año);
            float ingresoMensual = _finanzas.getSellsOfMonthEfectivo(mes, año);
            float ingresoMensualTarjeta = _finanzas.getSellsOfMonthTarjeta(mes, año);
            float ingresoMensualCuentaDNI = _finanzas.getSellsOfMonthDNI(mes, año);
            float ingresoMensualMercadoPago = _finanzas.getSellsOfMonthMercadoPago(mes, año);
            float gastoMensual = _finanzas.getLostsOfMonth(mes, año);
            float ingresoAnual = _finanzas.getSellsOfYear(año);
            float ingresoAnualTarjeta = _finanzas.getSellsOfYearTarjeta(año);
            float ingresoAnualCuentaDNI = _finanzas.getSellsOfYearDNI(año);
            float ingresoAnualMercadoPago = _finanzas.getSellsOfYearMercadoPago(año);
            float gastoAnual = _finanzas.getLostsOfYear(año);
            Globals.getSQLCon().closeDB();
            ingresosDiaLbl.Text = $"${ingresoDia}";
            this.ingresoDiaTarjeta.Text = $"${ingresoDiaTarjeta}";
            ingresoDiaDNI.Text = $"${ingresoDiaCuentaDNI}";
            ingresoDiaMP.Text = $"${ingresoDiaMercadoPago}";
            gastosDiaLbl.Text = $"${gastoDia}";
            totalDiaLbl.Text = $"${(ingresoDia + ingresoDiaTarjeta + ingresoDiaCuentaDNI + ingresoDiaMercadoPago) - gastoDia}";

            ingresoSemanaLbl.Text = $"${ingresoSemanal}";
            ingresoWeekTarjeta.Text = $"${ingresoSemanalTarjeta}";
            ingrsoWeekDNI.Text = $"${ingresoSemanalCuentaDNI}";
            ingresoWeekMP.Text = $"${ingresoSemanalMercadoPago}";
            gastoSemanaLbl.Text = $"${gastoSemanal}";
            totalSemanaLbl.Text = $"${(ingresoSemanal + ingresoSemanalTarjeta + ingresoSemanalCuentaDNI + ingresoSemanalMercadoPago) - gastoSemanal}";

            ingresoMesLbl.Text = $"${ingresoMensual}";
            IngrsoMesTarjeta.Text = $"${ingresoMensualTarjeta}";
            ingresoMesDNI.Text = $"${ingresoMensualCuentaDNI}";
            ingresoMesMP.Text = $"${ingresoMensualMercadoPago}";
            gastoMesLbl.Text = $"${gastoMensual}";
            totalMesLbl.Text = $"${(ingresoMensual + ingresoMensualTarjeta + ingresoMensualCuentaDNI + ingresoMensualMercadoPago) - gastoMensual}";

            ingresoAnualLbl.Text = $"${ingresoAnual}";
            ingresoAñoTarjeta.Text = $"${ingresoAnualTarjeta}";
            ingresoAñoDNI.Text = $"${ingresoAnualCuentaDNI}";
            ingresoAñoMP.Text = $"${ingresoAnualMercadoPago}";

            gastoAnualLbl.Text = $"${gastoAnual}";
            totalAnualLbl.Text = $"${(ingresoAnual + ingresoAnualTarjeta + ingresoAnualCuentaDNI + ingresoAnualMercadoPago) - gastoAnual}";
        }

        private void monthDetailsBtn_Click(object sender, EventArgs e)
        {
            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            FinanzasDetailsDate _form = new FinanzasDetailsDate();
            _form.setDate (mes, año);
            Globals.getMenu().openFormInPanel(_form);
        }

        private void anualDetailsBtn_Click(object sender, EventArgs e)
        {
            int año = DateTime.Now.Year;
            FinanzasDetailsDate _form = new FinanzasDetailsDate();
            _form.setDate(año);
            Globals.getMenu().openFormInPanel(_form);
        }

        private void weeklyDetailsBtn_Click(object sender, EventArgs e)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int año = DateTime.Now.Year;
            FinanzasDetails _form = new FinanzasDetails();
            _form.setDataOfWeek(dia, mes, año);
            Globals.getMenu().openFormInPanel(_form);
        }

        private void lostsBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(Globals.getGastos());
        }
    }
}
