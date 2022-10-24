
namespace Tienda
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sideBar = new Guna.UI.WinForms.GunaGradient2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuContainer = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.finanzasBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.productsBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ventasBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minBtn = new System.Windows.Forms.PictureBox();
            this.maxresBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxresBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.minBtn);
            this.gunaPanel1.Controls.Add(this.maxresBtn);
            this.gunaPanel1.Controls.Add(this.closeBtn);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1300, 30);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Celia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 670);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 667);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.sideBar);
            this.panel6.Location = new System.Drawing.Point(10, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 650);
            this.panel6.TabIndex = 0;
            // 
            // sideBar
            // 
            this.sideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.Controls.Add(this.finanzasBtn);
            this.sideBar.Controls.Add(this.productsBtn);
            this.sideBar.Controls.Add(this.ventasBtn);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.sideBar.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.sideBar.Location = new System.Drawing.Point(5, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Radius = 10;
            this.sideBar.Size = new System.Drawing.Size(225, 650);
            this.sideBar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gunaSeparator1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 89);
            this.panel3.TabIndex = 0;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.White;
            this.gunaSeparator1.Location = new System.Drawing.Point(13, 61);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator1.TabIndex = 1;
            this.gunaSeparator1.Thickness = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(247, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 670);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.menuContainer);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 661);
            this.panel5.TabIndex = 1;
            // 
            // menuContainer
            // 
            this.menuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.menuContainer.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.menuContainer.Location = new System.Drawing.Point(3, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Radius = 10;
            this.menuContainer.Size = new System.Drawing.Size(1022, 650);
            this.menuContainer.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // finanzasBtn
            // 
            this.finanzasBtn.AnimationHoverSpeed = 0.07F;
            this.finanzasBtn.AnimationSpeed = 0.03F;
            this.finanzasBtn.BaseColor = System.Drawing.Color.Transparent;
            this.finanzasBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.finanzasBtn.BorderSize = 1;
            this.finanzasBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.finanzasBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.finanzasBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.finanzasBtn.CheckedForeColor = System.Drawing.Color.White;
            this.finanzasBtn.CheckedImage = global::Tienda.Properties.Resources.icons8_ledger_30px_1;
            this.finanzasBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.finanzasBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.finanzasBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.finanzasBtn.FocusedColor = System.Drawing.Color.Empty;
            this.finanzasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finanzasBtn.ForeColor = System.Drawing.Color.White;
            this.finanzasBtn.Image = global::Tienda.Properties.Resources.icons8_ledger_30px;
            this.finanzasBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.finanzasBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.finanzasBtn.LineLeft = 2;
            this.finanzasBtn.Location = new System.Drawing.Point(0, 173);
            this.finanzasBtn.Name = "finanzasBtn";
            this.finanzasBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.finanzasBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.finanzasBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.finanzasBtn.OnHoverImage = null;
            this.finanzasBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.finanzasBtn.OnPressedColor = System.Drawing.Color.Black;
            this.finanzasBtn.Size = new System.Drawing.Size(225, 42);
            this.finanzasBtn.TabIndex = 2;
            this.finanzasBtn.Text = "Finanzas";
            this.finanzasBtn.Click += new System.EventHandler(this.finanzasBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.AnimationHoverSpeed = 0.07F;
            this.productsBtn.AnimationSpeed = 0.03F;
            this.productsBtn.BaseColor = System.Drawing.Color.Transparent;
            this.productsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.productsBtn.BorderSize = 1;
            this.productsBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.productsBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.productsBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.productsBtn.CheckedForeColor = System.Drawing.Color.White;
            this.productsBtn.CheckedImage = global::Tienda.Properties.Resources.icons8_clothes_64px_1;
            this.productsBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.productsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.productsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Image = global::Tienda.Properties.Resources.icons8_clothes_64px;
            this.productsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.productsBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.productsBtn.LineLeft = 2;
            this.productsBtn.Location = new System.Drawing.Point(0, 131);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.productsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.productsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.productsBtn.OnHoverImage = null;
            this.productsBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.productsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.productsBtn.Size = new System.Drawing.Size(225, 42);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Productos";
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // ventasBtn
            // 
            this.ventasBtn.AnimationHoverSpeed = 0.07F;
            this.ventasBtn.AnimationSpeed = 0.03F;
            this.ventasBtn.BaseColor = System.Drawing.Color.Transparent;
            this.ventasBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.ventasBtn.BorderSize = 1;
            this.ventasBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.ventasBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.ventasBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ventasBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ventasBtn.CheckedImage = global::Tienda.Properties.Resources.icons8_checkout_80px_1;
            this.ventasBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.ventasBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ventasBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventasBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ventasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasBtn.ForeColor = System.Drawing.Color.White;
            this.ventasBtn.Image = global::Tienda.Properties.Resources.icons8_checkout_80px;
            this.ventasBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ventasBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ventasBtn.LineLeft = 2;
            this.ventasBtn.Location = new System.Drawing.Point(0, 89);
            this.ventasBtn.Name = "ventasBtn";
            this.ventasBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.ventasBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ventasBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ventasBtn.OnHoverImage = null;
            this.ventasBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ventasBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ventasBtn.Size = new System.Drawing.Size(225, 42);
            this.ventasBtn.TabIndex = 0;
            this.ventasBtn.Text = "Vender";
            this.ventasBtn.Click += new System.EventHandler(this.ventasBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda.Properties.Resources.icons8_shop_80px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.Image = global::Tienda.Properties.Resources.Minimize_Window_2_48px;
            this.minBtn.Location = new System.Drawing.Point(1198, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(30, 30);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 3;
            this.minBtn.TabStop = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // maxresBtn
            // 
            this.maxresBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxresBtn.Image = global::Tienda.Properties.Resources.Maximize_Window_2_48px;
            this.maxresBtn.Location = new System.Drawing.Point(1232, 0);
            this.maxresBtn.Name = "maxresBtn";
            this.maxresBtn.Size = new System.Drawing.Size(30, 30);
            this.maxresBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxresBtn.TabIndex = 2;
            this.maxresBtn.TabStop = false;
            this.maxresBtn.Click += new System.EventHandler(this.maxresBtn_Click);
            this.maxresBtn.MouseEnter += new System.EventHandler(this.maxresBtn_MouseEnter);
            this.maxresBtn.MouseLeave += new System.EventHandler(this.maxresBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Image = global::Tienda.Properties.Resources.Close_Window__2_48px;
            this.closeBtn.Location = new System.Drawing.Point(1266, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma Celia ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxresBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradient2Panel sideBar;
        private Guna.UI.WinForms.GunaGradient2Panel menuContainer;
        private Guna.UI.WinForms.GunaAdvenceButton ventasBtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton finanzasBtn;
        private Guna.UI.WinForms.GunaAdvenceButton productsBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minBtn;
        private System.Windows.Forms.PictureBox maxresBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

