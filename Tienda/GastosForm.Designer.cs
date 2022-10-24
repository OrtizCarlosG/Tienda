
namespace Tienda
{
    partial class GastosForm
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
            this.deleteBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.modLostBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.addLostBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.deleteBtn);
            this.gunaGradient2Panel1.Controls.Add(this.modLostBtn);
            this.gunaGradient2Panel1.Controls.Add(this.addLostBtn);
            this.gunaGradient2Panel1.Controls.Add(this.dataGridView1);
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
            this.deleteBtn.Location = new System.Drawing.Point(817, 569);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.deleteBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(160, 42);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Eliminar gasto";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modLostBtn
            // 
            this.modLostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modLostBtn.AnimationHoverSpeed = 0.07F;
            this.modLostBtn.AnimationSpeed = 0.03F;
            this.modLostBtn.BackColor = System.Drawing.Color.Transparent;
            this.modLostBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.modLostBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.modLostBtn.BorderColor = System.Drawing.Color.Black;
            this.modLostBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modLostBtn.FocusedColor = System.Drawing.Color.Empty;
            this.modLostBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modLostBtn.ForeColor = System.Drawing.Color.White;
            this.modLostBtn.Image = global::Tienda.Properties.Resources.icons8_edit_property_32px;
            this.modLostBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.modLostBtn.Location = new System.Drawing.Point(420, 569);
            this.modLostBtn.Name = "modLostBtn";
            this.modLostBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.modLostBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.modLostBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.modLostBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.modLostBtn.OnHoverImage = null;
            this.modLostBtn.OnPressedColor = System.Drawing.Color.Black;
            this.modLostBtn.Radius = 10;
            this.modLostBtn.Size = new System.Drawing.Size(160, 42);
            this.modLostBtn.TabIndex = 16;
            this.modLostBtn.Text = "Modificar gasto";
            this.modLostBtn.Click += new System.EventHandler(this.modLostBtn_Click);
            // 
            // addLostBtn
            // 
            this.addLostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addLostBtn.AnimationHoverSpeed = 0.07F;
            this.addLostBtn.AnimationSpeed = 0.03F;
            this.addLostBtn.BackColor = System.Drawing.Color.Transparent;
            this.addLostBtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.addLostBtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.addLostBtn.BorderColor = System.Drawing.Color.Black;
            this.addLostBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addLostBtn.FocusedColor = System.Drawing.Color.Empty;
            this.addLostBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addLostBtn.ForeColor = System.Drawing.Color.White;
            this.addLostBtn.Image = global::Tienda.Properties.Resources.icons8_request_money_80px;
            this.addLostBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addLostBtn.Location = new System.Drawing.Point(35, 569);
            this.addLostBtn.Name = "addLostBtn";
            this.addLostBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.addLostBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.addLostBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addLostBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addLostBtn.OnHoverImage = null;
            this.addLostBtn.OnPressedColor = System.Drawing.Color.Black;
            this.addLostBtn.Radius = 10;
            this.addLostBtn.Size = new System.Drawing.Size(160, 42);
            this.addLostBtn.TabIndex = 15;
            this.addLostBtn.Text = "Agregar gasto";
            this.addLostBtn.Click += new System.EventHandler(this.addLostBtn_Click);
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
            this.ID,
            this.Detalle,
            this.Monto});
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 67);
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
            this.dataGridView1.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1022, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Registro de gastos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GastosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1022, 650);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GastosForm";
            this.Text = "GastosForm";
            this.Load += new System.EventHandler(this.GastosForm_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton deleteBtn;
        private Guna.UI.WinForms.GunaGradientButton modLostBtn;
        private Guna.UI.WinForms.GunaGradientButton addLostBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}