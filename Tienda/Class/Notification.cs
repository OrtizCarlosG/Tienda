using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Properties;

namespace Tienda.Class
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }
        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;
        public void setAlert(string msg, string tittle, Notification.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notification f = (Notification)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 10 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case Notification.alertTypeEnum.Success:
                    this.pictureBox1.Image = Resources.Checkmark_28px;
                    gunaGradient2Panel2.GradientColor1 = Color.FromArgb(42, 171, 160);
                    gunaGradient2Panel2.GradientColor2 = Color.FromArgb(32, 232, 160);
                    break;
                case Notification.alertTypeEnum.Warning:
                    this.pictureBox1.Image = Resources.Warning_28px;
                    gunaGradient2Panel2.GradientColor1 = Color.FromArgb(255, 179, 2);
                    gunaGradient2Panel2.GradientColor2 = Color.DarkOrange;
                    break;
                case Notification.alertTypeEnum.Error:
                    this.pictureBox1.Image = Resources.Error_28px;
                    gunaGradient2Panel2.GradientColor1 = Color.FromArgb(255, 50, 20);
                    gunaGradient2Panel2.GradientColor2 = Color.Maroon;
                    break;
                case Notification.alertTypeEnum.Info:
                    this.pictureBox1.Image = Resources.Info_28px;
                    gunaGradient2Panel2.GradientColor1 = Color.FromArgb(71, 169, 248);
                    gunaGradient2Panel2.GradientColor2 = Color.DeepSkyBlue;
                    break;
            }
            this.label2.Text = msg;
            this.tittleLbl.Text = tittle;

            this.TopMost = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private Notification.actionEnum action;


        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = Notification.actionEnum.close;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Notification.actionEnum.wait:
                    this.timer1.Interval = 5000;
                    this.action = Notification.actionEnum.close;
                    break;
                case Notification.actionEnum.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.y < this.Location.Y)
                    {
                        this.Top++;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = Notification.actionEnum.wait;
                        }
                    }
                    break;
                case Notification.actionEnum.close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Top += 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
