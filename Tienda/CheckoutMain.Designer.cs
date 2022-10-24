
namespace Tienda
{
    partial class CheckoutMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTxt = new ProyectoZ.UI.ProyectoZTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productossBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.checkoutBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.discountBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.modifyProductBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.searchProdBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.addProdBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.productossBtn);
            this.gunaGradient2Panel1.Controls.Add(this.totalLbl);
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Controls.Add(this.checkoutBtn);
            this.gunaGradient2Panel1.Controls.Add(this.deleteBtn);
            this.gunaGradient2Panel1.Controls.Add(this.discountBtn);
            this.gunaGradient2Panel1.Controls.Add(this.modifyProductBtn);
            this.gunaGradient2Panel1.Controls.Add(this.searchProdBtn);
            this.gunaGradient2Panel1.Controls.Add(this.addProdBtn);
            this.gunaGradient2Panel1.Controls.Add(this.dataGridView1);
            this.gunaGradient2Panel1.Controls.Add(this.searchTxt);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox1);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.label2);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 10;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1022, 650);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // totalLbl
            // 
            this.totalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(800, 24);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(0, 29);
            this.totalLbl.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(746, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Tipo,
            this.Talle,
            this.Precio,
            this.Sexo,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.dataGridView1.Location = new System.Drawing.Point(37, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(945, 483);
            this.dataGridView1.TabIndex = 12;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Talle
            // 
            this.Talle.DataPropertyName = "Talle";
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(254)))));
            this.searchTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.searchTxt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(104)))), ((int)(((byte)(241)))));
            this.searchTxt.BorderRadius = 10;
            this.searchTxt.BorderSize = 2;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.ForeColor = System.Drawing.Color.White;
            this.searchTxt.Location = new System.Drawing.Point(306, 30);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.MaxTextLenght = 32767;
            this.searchTxt.Multiline = false;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTxt.PasswordChar = false;
            this.searchTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTxt.PlaceholderText = "Ingrese aqui el codigo del producto que desee añadir al carrito";
            this.searchTxt.Size = new System.Drawing.Size(433, 31);
            this.searchTxt.TabIndex = 11;
            this.searchTxt.Texts = "";
            this.searchTxt.UnderlinedStyle = true;
            this.searchTxt._TextChanged += new System.EventHandler(this.searchTxt__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingresa el codigo de los productos";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1022, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ventas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productossBtn
            // 
            this.productossBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.productossBtn.AnimationHoverSpeed = 0.07F;
            this.productossBtn.AnimationSpeed = 0.03F;
            this.productossBtn.BackColor = System.Drawing.Color.Transparent;
            this.productossBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.productossBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.productossBtn.BorderColor = System.Drawing.Color.Black;
            this.productossBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.productossBtn.FocusedColor = System.Drawing.Color.Empty;
            this.productossBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productossBtn.ForeColor = System.Drawing.Color.White;
            this.productossBtn.Image = global::Tienda.Properties.Resources.icons8_product_64px;
            this.productossBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.productossBtn.Location = new System.Drawing.Point(734, 569);
            this.productossBtn.Name = "productossBtn";
            this.productossBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.productossBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.productossBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.productossBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.productossBtn.OnHoverImage = null;
            this.productossBtn.OnPressedColor = System.Drawing.Color.Black;
            this.productossBtn.Radius = 10;
            this.productossBtn.Size = new System.Drawing.Size(140, 42);
            this.productossBtn.TabIndex = 24;
            this.productossBtn.Text = "Producto SS";
            this.productossBtn.Click += new System.EventHandler(this.productossBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkoutBtn.AnimationHoverSpeed = 0.07F;
            this.checkoutBtn.AnimationSpeed = 0.03F;
            this.checkoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkoutBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.checkoutBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.checkoutBtn.BorderColor = System.Drawing.Color.Black;
            this.checkoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.checkoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = global::Tienda.Properties.Resources.icons8_cash_register_64px;
            this.checkoutBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.checkoutBtn.Location = new System.Drawing.Point(880, 569);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.checkoutBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.checkoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.checkoutBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.checkoutBtn.OnHoverImage = null;
            this.checkoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.checkoutBtn.Radius = 10;
            this.checkoutBtn.Size = new System.Drawing.Size(140, 42);
            this.checkoutBtn.TabIndex = 21;
            this.checkoutBtn.Text = "Finalizar compra";
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.AnimationHoverSpeed = 0.07F;
            this.deleteBtn.AnimationSpeed = 0.03F;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.deleteBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::Tienda.Properties.Resources.icons8_cancel_26px;
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.Location = new System.Drawing.Point(588, 569);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.deleteBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(140, 42);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Eliminar del carrito";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.discountBtn.AnimationHoverSpeed = 0.07F;
            this.discountBtn.AnimationSpeed = 0.03F;
            this.discountBtn.BackColor = System.Drawing.Color.Transparent;
            this.discountBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.discountBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.discountBtn.BorderColor = System.Drawing.Color.Black;
            this.discountBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.discountBtn.FocusedColor = System.Drawing.Color.Empty;
            this.discountBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discountBtn.ForeColor = System.Drawing.Color.White;
            this.discountBtn.Image = global::Tienda.Properties.Resources.icons8_discount_30px;
            this.discountBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.discountBtn.Location = new System.Drawing.Point(442, 569);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.discountBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.discountBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.discountBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.discountBtn.OnHoverImage = null;
            this.discountBtn.OnPressedColor = System.Drawing.Color.Black;
            this.discountBtn.Radius = 10;
            this.discountBtn.Size = new System.Drawing.Size(140, 42);
            this.discountBtn.TabIndex = 16;
            this.discountBtn.Text = "Aplicar descuento";
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // modifyProductBtn
            // 
            this.modifyProductBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modifyProductBtn.AnimationHoverSpeed = 0.07F;
            this.modifyProductBtn.AnimationSpeed = 0.03F;
            this.modifyProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.modifyProductBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.modifyProductBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.modifyProductBtn.BorderColor = System.Drawing.Color.Black;
            this.modifyProductBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modifyProductBtn.FocusedColor = System.Drawing.Color.Empty;
            this.modifyProductBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifyProductBtn.ForeColor = System.Drawing.Color.White;
            this.modifyProductBtn.Image = global::Tienda.Properties.Resources.icons8_edit_property_32px;
            this.modifyProductBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.modifyProductBtn.Location = new System.Drawing.Point(296, 569);
            this.modifyProductBtn.Name = "modifyProductBtn";
            this.modifyProductBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.modifyProductBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.modifyProductBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.modifyProductBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.modifyProductBtn.OnHoverImage = null;
            this.modifyProductBtn.OnPressedColor = System.Drawing.Color.Black;
            this.modifyProductBtn.Radius = 10;
            this.modifyProductBtn.Size = new System.Drawing.Size(140, 42);
            this.modifyProductBtn.TabIndex = 15;
            this.modifyProductBtn.Text = "Cambiar cantidad";
            this.modifyProductBtn.Click += new System.EventHandler(this.modifyProductBtn_Click);
            // 
            // searchProdBtn
            // 
            this.searchProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchProdBtn.AnimationHoverSpeed = 0.07F;
            this.searchProdBtn.AnimationSpeed = 0.03F;
            this.searchProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchProdBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.searchProdBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.searchProdBtn.BorderColor = System.Drawing.Color.Black;
            this.searchProdBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchProdBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchProdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchProdBtn.ForeColor = System.Drawing.Color.White;
            this.searchProdBtn.Image = global::Tienda.Properties.Resources.icons8_search_26px;
            this.searchProdBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchProdBtn.Location = new System.Drawing.Point(150, 569);
            this.searchProdBtn.Name = "searchProdBtn";
            this.searchProdBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.searchProdBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.searchProdBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchProdBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchProdBtn.OnHoverImage = null;
            this.searchProdBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchProdBtn.Radius = 10;
            this.searchProdBtn.Size = new System.Drawing.Size(140, 42);
            this.searchProdBtn.TabIndex = 14;
            this.searchProdBtn.Text = "Buscar producto";
            this.searchProdBtn.Click += new System.EventHandler(this.searchProdBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addProdBtn.AnimationHoverSpeed = 0.07F;
            this.addProdBtn.AnimationSpeed = 0.03F;
            this.addProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.addProdBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.addProdBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.addProdBtn.BorderColor = System.Drawing.Color.Black;
            this.addProdBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addProdBtn.FocusedColor = System.Drawing.Color.Empty;
            this.addProdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Image = global::Tienda.Properties.Resources.icons8_checkout_32px;
            this.addProdBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addProdBtn.Location = new System.Drawing.Point(4, 569);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.addProdBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.addProdBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addProdBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addProdBtn.OnHoverImage = null;
            this.addProdBtn.OnPressedColor = System.Drawing.Color.Black;
            this.addProdBtn.Radius = 10;
            this.addProdBtn.Size = new System.Drawing.Size(140, 42);
            this.addProdBtn.TabIndex = 13;
            this.addProdBtn.Text = "Agregar al carrito";
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda.Properties.Resources.icons8_clothes_64px;
            this.pictureBox1.Location = new System.Drawing.Point(30, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CheckoutMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1022, 650);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutMain";
            this.Text = "CheckoutMain";
            this.Load += new System.EventHandler(this.CheckoutMain_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label label2;
        private ProyectoZ.UI.ProyectoZTextBox searchTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private Guna.UI.WinForms.GunaGradientButton addProdBtn;
        private Guna.UI.WinForms.GunaGradientButton searchProdBtn;
        private Guna.UI.WinForms.GunaGradientButton modifyProductBtn;
        private Guna.UI.WinForms.GunaGradientButton discountBtn;
        private Guna.UI.WinForms.GunaGradientButton deleteBtn;
        private Guna.UI.WinForms.GunaGradientButton checkoutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLbl;
        private Guna.UI.WinForms.GunaGradientButton productossBtn;
    }
}