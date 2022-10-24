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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Globals.setMenu(this);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            IniReader reader = new IniReader("Data/conexion.ini");
            Globals.getSQLCon().SQL_Connect(reader.GetValue("Server", "CONEXION SQL"), reader.GetValue("Usuario", "CONEXION SQL"), reader.GetValue("Password", "CONEXION SQL"), "Tienda");
        }

        public void openFormInPanel(Form form)
        {
            if (menuContainer.Controls.Count > 0)
            {
                menuContainer.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.AutoScroll = true;
            this.menuContainer.Controls.Add(form);
            form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TransparencyKey = form.BackColor;
            form.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            openFormInPanel(new ProductosMain());
        }

        private void ventasBtn_Click(object sender, EventArgs e)
        {
            openFormInPanel(Globals.getCheckout());
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(100, 255, 0, 0);
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Transparent;
        }

        private void maxresBtn_MouseEnter(object sender, EventArgs e)
        {
            maxresBtn.BackColor = Color.FromArgb(125, 125, 125, 125);
        }

        private void maxresBtn_MouseLeave(object sender, EventArgs e)
        {
            maxresBtn.BackColor = Color.Transparent;
        }

        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            minBtn.BackColor = Color.FromArgb(125, 125, 125, 125);
        }

        private void minBtn_MouseLeave(object sender, EventArgs e)
        {
            minBtn.BackColor = Color.Transparent;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maxresBtn_Click(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maxresBtn.Image = Properties.Resources.Restore_Window_2_48px;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxresBtn.Image = Properties.Resources.Maximize_Window_2_48px;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void finanzasBtn_Click(object sender, EventArgs e)
        {
            openFormInPanel(new FinanzasMain());
        }
    }
}
