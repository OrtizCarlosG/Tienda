
namespace Tienda
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.closeBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.finCheckoutBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.mercadoPagoRadio = new ProyectoZ.UI.ProyectoZRadioButton();
            this.cuentaDNIRadio = new ProyectoZ.UI.ProyectoZRadioButton();
            this.tarjetaRadio = new ProyectoZ.UI.ProyectoZRadioButton();
            this.efectivoRadio = new ProyectoZ.UI.ProyectoZRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.closeBtn);
            this.gunaGradient2Panel1.Controls.Add(this.finCheckoutBtn);
            this.gunaGradient2Panel1.Controls.Add(this.mercadoPagoRadio);
            this.gunaGradient2Panel1.Controls.Add(this.cuentaDNIRadio);
            this.gunaGradient2Panel1.Controls.Add(this.tarjetaRadio);
            this.gunaGradient2Panel1.Controls.Add(this.efectivoRadio);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradient2Panel2);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 10;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(564, 240);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.AnimationHoverSpeed = 0.07F;
            this.closeBtn.AnimationSpeed = 0.03F;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.closeBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.closeBtn.BorderColor = System.Drawing.Color.Black;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = global::Tienda.Properties.Resources.icons8_cancel_26px;
            this.closeBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeBtn.Location = new System.Drawing.Point(294, 174);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.closeBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.closeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.closeBtn.OnHoverImage = null;
            this.closeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.closeBtn.Radius = 10;
            this.closeBtn.Size = new System.Drawing.Size(160, 42);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "Cancelar";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // finCheckoutBtn
            // 
            this.finCheckoutBtn.AnimationHoverSpeed = 0.07F;
            this.finCheckoutBtn.AnimationSpeed = 0.03F;
            this.finCheckoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.finCheckoutBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.finCheckoutBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.finCheckoutBtn.BorderColor = System.Drawing.Color.Black;
            this.finCheckoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.finCheckoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.finCheckoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finCheckoutBtn.ForeColor = System.Drawing.Color.White;
            this.finCheckoutBtn.Image = global::Tienda.Properties.Resources.icons8_cash_register_64px;
            this.finCheckoutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.finCheckoutBtn.Location = new System.Drawing.Point(90, 174);
            this.finCheckoutBtn.Name = "finCheckoutBtn";
            this.finCheckoutBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.finCheckoutBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.finCheckoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.finCheckoutBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.finCheckoutBtn.OnHoverImage = null;
            this.finCheckoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.finCheckoutBtn.Radius = 10;
            this.finCheckoutBtn.Size = new System.Drawing.Size(160, 42);
            this.finCheckoutBtn.TabIndex = 16;
            this.finCheckoutBtn.Text = "Finalizar venta";
            this.finCheckoutBtn.Click += new System.EventHandler(this.finCheckoutBtn_Click);
            // 
            // mercadoPagoRadio
            // 
            this.mercadoPagoRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mercadoPagoRadio.AutoSize = true;
            this.mercadoPagoRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.mercadoPagoRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.mercadoPagoRadio.ForeColor = System.Drawing.Color.White;
            this.mercadoPagoRadio.Location = new System.Drawing.Point(404, 88);
            this.mercadoPagoRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.mercadoPagoRadio.Name = "mercadoPagoRadio";
            this.mercadoPagoRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mercadoPagoRadio.Size = new System.Drawing.Size(102, 21);
            this.mercadoPagoRadio.TabIndex = 14;
            this.mercadoPagoRadio.TabStop = true;
            this.mercadoPagoRadio.Text = "MercadoPago";
            this.mercadoPagoRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.mercadoPagoRadio.UseVisualStyleBackColor = false;
            // 
            // cuentaDNIRadio
            // 
            this.cuentaDNIRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuentaDNIRadio.AutoSize = true;
            this.cuentaDNIRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.cuentaDNIRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.cuentaDNIRadio.ForeColor = System.Drawing.Color.White;
            this.cuentaDNIRadio.Location = new System.Drawing.Point(284, 88);
            this.cuentaDNIRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.cuentaDNIRadio.Name = "cuentaDNIRadio";
            this.cuentaDNIRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cuentaDNIRadio.Size = new System.Drawing.Size(91, 21);
            this.cuentaDNIRadio.TabIndex = 13;
            this.cuentaDNIRadio.TabStop = true;
            this.cuentaDNIRadio.Text = "Cuenta DNI";
            this.cuentaDNIRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.cuentaDNIRadio.UseVisualStyleBackColor = false;
            // 
            // tarjetaRadio
            // 
            this.tarjetaRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarjetaRadio.AutoSize = true;
            this.tarjetaRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.tarjetaRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.tarjetaRadio.ForeColor = System.Drawing.Color.White;
            this.tarjetaRadio.Location = new System.Drawing.Point(173, 88);
            this.tarjetaRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.tarjetaRadio.Name = "tarjetaRadio";
            this.tarjetaRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tarjetaRadio.Size = new System.Drawing.Size(68, 21);
            this.tarjetaRadio.TabIndex = 12;
            this.tarjetaRadio.TabStop = true;
            this.tarjetaRadio.Text = "Tarjeta";
            this.tarjetaRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.tarjetaRadio.UseVisualStyleBackColor = false;
            // 
            // efectivoRadio
            // 
            this.efectivoRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.efectivoRadio.AutoSize = true;
            this.efectivoRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.efectivoRadio.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.efectivoRadio.ForeColor = System.Drawing.Color.White;
            this.efectivoRadio.Location = new System.Drawing.Point(61, 88);
            this.efectivoRadio.MinimumSize = new System.Drawing.Size(0, 21);
            this.efectivoRadio.Name = "efectivoRadio";
            this.efectivoRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.efectivoRadio.Size = new System.Drawing.Size(74, 21);
            this.efectivoRadio.TabIndex = 11;
            this.efectivoRadio.TabStop = true;
            this.efectivoRadio.Text = "Efectivo";
            this.efectivoRadio.UnCheckedColor = System.Drawing.Color.Gray;
            this.efectivoRadio.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione con que desea abonar:";
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.label2);
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 2;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(564, 25);
            this.gunaGradient2Panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Finalizar venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(564, 240);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProyectoZ.UI.ProyectoZRadioButton efectivoRadio;
        private ProyectoZ.UI.ProyectoZRadioButton tarjetaRadio;
        private ProyectoZ.UI.ProyectoZRadioButton cuentaDNIRadio;
        private ProyectoZ.UI.ProyectoZRadioButton mercadoPagoRadio;
        private Guna.UI.WinForms.GunaGradientButton closeBtn;
        private Guna.UI.WinForms.GunaGradientButton finCheckoutBtn;
    }
}