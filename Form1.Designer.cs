namespace Proyecto_progra2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigo = new ReaLTaiizor.Controls.HopeTextBox();
            cmbTipo = new ReaLTaiizor.Controls.ForeverComboBox();
            txtMarca = new ReaLTaiizor.Controls.HopeTextBox();
            txtModelo = new ReaLTaiizor.Controls.HopeTextBox();
            cmbUbicacion = new ReaLTaiizor.Controls.ForeverComboBox();
            cmbEstado = new ReaLTaiizor.Controls.ForeverComboBox();
            btnAgregarEquipo = new ReaLTaiizor.Controls.NightButton();
            dgvEquipos = new DataGridView();
            txtSerie = new ReaLTaiizor.Controls.HopeTextBox();
            btnVerManteniemintos = new ReaLTaiizor.Controls.NightButton();
            smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel2 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel3 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel4 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel5 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel6 = new ReaLTaiizor.Controls.SmallLabel();
            smallLabel7 = new ReaLTaiizor.Controls.SmallLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(0, 192, 192);
            txtCodigo.BaseColor = Color.FromArgb(44, 55, 66);
            txtCodigo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCodigo.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.ForeColor = Color.FromArgb(48, 49, 51);
            txtCodigo.Hint = "";
            txtCodigo.Location = new Point(78, 12);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.MaxLength = 32767;
            txtCodigo.Multiline = false;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.ScrollBars = ScrollBars.None;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.Size = new Size(82, 38);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.Text = "hopeTextBox1";
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // cmbTipo
            // 
            cmbTipo.BaseColor = Color.FromArgb(25, 27, 29);
            cmbTipo.BGColor = Color.FromArgb(45, 47, 49);
            cmbTipo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 8F);
            cmbTipo.ForeColor = Color.White;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.HoverColor = Color.FromArgb(35, 168, 109);
            cmbTipo.HoverFontColor = Color.White;
            cmbTipo.ItemHeight = 18;
            cmbTipo.Items.AddRange(new object[] { "Laptop", "Impresora", "Mouse", "Teclado" });
            cmbTipo.Location = new Point(78, 70);
            cmbTipo.Margin = new Padding(3, 2, 3, 2);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(133, 24);
            cmbTipo.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(0, 192, 192);
            txtMarca.BaseColor = Color.FromArgb(44, 55, 66);
            txtMarca.BorderColorA = Color.FromArgb(64, 158, 255);
            txtMarca.BorderColorB = Color.FromArgb(220, 223, 230);
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.ForeColor = Color.FromArgb(48, 49, 51);
            txtMarca.Hint = "";
            txtMarca.Location = new Point(78, 188);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.MaxLength = 32767;
            txtMarca.Multiline = false;
            txtMarca.Name = "txtMarca";
            txtMarca.PasswordChar = '\0';
            txtMarca.ScrollBars = ScrollBars.None;
            txtMarca.SelectedText = "";
            txtMarca.SelectionLength = 0;
            txtMarca.SelectionStart = 0;
            txtMarca.Size = new Size(87, 38);
            txtMarca.TabIndex = 2;
            txtMarca.TabStop = false;
            txtMarca.Text = "MARCA";
            txtMarca.UseSystemPasswordChar = false;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(0, 192, 192);
            txtModelo.BaseColor = Color.FromArgb(44, 55, 66);
            txtModelo.BorderColorA = Color.FromArgb(64, 158, 255);
            txtModelo.BorderColorB = Color.FromArgb(220, 223, 230);
            txtModelo.Font = new Font("Segoe UI", 12F);
            txtModelo.ForeColor = Color.FromArgb(48, 49, 51);
            txtModelo.Hint = "";
            txtModelo.Location = new Point(78, 238);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.MaxLength = 32767;
            txtModelo.Multiline = false;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.ScrollBars = ScrollBars.None;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.Size = new Size(96, 38);
            txtModelo.TabIndex = 3;
            txtModelo.TabStop = false;
            txtModelo.Text = "MODELO";
            txtModelo.UseSystemPasswordChar = false;
            // 
            // cmbUbicacion
            // 
            cmbUbicacion.BaseColor = Color.FromArgb(25, 27, 29);
            cmbUbicacion.BGColor = Color.FromArgb(45, 47, 49);
            cmbUbicacion.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUbicacion.Font = new Font("Segoe UI", 8F);
            cmbUbicacion.ForeColor = Color.White;
            cmbUbicacion.FormattingEnabled = true;
            cmbUbicacion.HoverColor = Color.FromArgb(35, 168, 109);
            cmbUbicacion.HoverFontColor = Color.White;
            cmbUbicacion.ItemHeight = 18;
            cmbUbicacion.Items.AddRange(new object[] { "Oficina", "Laboratorio", "Departamento" });
            cmbUbicacion.Location = new Point(78, 111);
            cmbUbicacion.Margin = new Padding(3, 2, 3, 2);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(133, 24);
            cmbUbicacion.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.BaseColor = Color.FromArgb(25, 27, 29);
            cmbEstado.BGColor = Color.FromArgb(45, 47, 49);
            cmbEstado.DrawMode = DrawMode.OwnerDrawFixed;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 8F);
            cmbEstado.ForeColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.HoverColor = Color.FromArgb(35, 168, 109);
            cmbEstado.HoverFontColor = Color.White;
            cmbEstado.ItemHeight = 18;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Reparacion", "Dado de baja" });
            cmbEstado.Location = new Point(78, 149);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(133, 24);
            cmbEstado.TabIndex = 5;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.Transparent;
            btnAgregarEquipo.DialogResult = DialogResult.None;
            btnAgregarEquipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEquipo.ForeColor = Color.Black;
            btnAgregarEquipo.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnAgregarEquipo.HoverForeColor = Color.WhiteSmoke;
            btnAgregarEquipo.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnAgregarEquipo.Location = new Point(470, 204);
            btnAgregarEquipo.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEquipo.MinimumSize = new Size(126, 35);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.NormalBackColor = Color.Cyan;
            btnAgregarEquipo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAgregarEquipo.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAgregarEquipo.PressedForeColor = Color.FromArgb(0, 192, 192);
            btnAgregarEquipo.Radius = 20;
            btnAgregarEquipo.Size = new Size(158, 44);
            btnAgregarEquipo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAgregarEquipo.TabIndex = 6;
            btnAgregarEquipo.Text = "AGREGAR EQUIPO";
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(387, 29);
            dgvEquipos.Margin = new Padding(3, 2, 3, 2);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(262, 141);
            dgvEquipos.TabIndex = 7;
            // 
            // txtSerie
            // 
            txtSerie.BackColor = Color.FromArgb(0, 192, 192);
            txtSerie.BaseColor = Color.FromArgb(44, 55, 66);
            txtSerie.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSerie.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSerie.Font = new Font("Segoe UI", 12F);
            txtSerie.ForeColor = Color.FromArgb(48, 49, 51);
            txtSerie.Hint = "";
            txtSerie.Location = new Point(78, 289);
            txtSerie.Margin = new Padding(3, 2, 3, 2);
            txtSerie.MaxLength = 32767;
            txtSerie.Multiline = false;
            txtSerie.Name = "txtSerie";
            txtSerie.PasswordChar = '\0';
            txtSerie.ScrollBars = ScrollBars.None;
            txtSerie.SelectedText = "";
            txtSerie.SelectionLength = 0;
            txtSerie.SelectionStart = 0;
            txtSerie.Size = new Size(81, 38);
            txtSerie.TabIndex = 8;
            txtSerie.TabStop = false;
            txtSerie.Text = "SERIE";
            txtSerie.UseSystemPasswordChar = false;
            // 
            // btnVerManteniemintos
            // 
            btnVerManteniemintos.BackColor = Color.Transparent;
            btnVerManteniemintos.DialogResult = DialogResult.None;
            btnVerManteniemintos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerManteniemintos.ForeColor = Color.Black;
            btnVerManteniemintos.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btnVerManteniemintos.HoverForeColor = Color.White;
            btnVerManteniemintos.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btnVerManteniemintos.Location = new Point(470, 278);
            btnVerManteniemintos.Margin = new Padding(3, 2, 3, 2);
            btnVerManteniemintos.MinimumSize = new Size(126, 35);
            btnVerManteniemintos.Name = "btnVerManteniemintos";
            btnVerManteniemintos.NormalBackColor = Color.Cyan;
            btnVerManteniemintos.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnVerManteniemintos.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnVerManteniemintos.PressedForeColor = Color.White;
            btnVerManteniemintos.Radius = 20;
            btnVerManteniemintos.Size = new Size(158, 44);
            btnVerManteniemintos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnVerManteniemintos.TabIndex = 9;
            btnVerManteniemintos.Text = "MANTENIMIENTOS";
            btnVerManteniemintos.Click += btnVerManteniemintos_Click;
            // 
            // smallLabel1
            // 
            smallLabel1.AutoSize = true;
            smallLabel1.BackColor = Color.Transparent;
            smallLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel1.ForeColor = Color.White;
            smallLabel1.Location = new Point(8, 21);
            smallLabel1.Name = "smallLabel1";
            smallLabel1.Size = new Size(60, 21);
            smallLabel1.TabIndex = 10;
            smallLabel1.Text = "Codigo";
            // 
            // smallLabel2
            // 
            smallLabel2.AutoSize = true;
            smallLabel2.BackColor = Color.Transparent;
            smallLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel2.ForeColor = Color.White;
            smallLabel2.Location = new Point(12, 70);
            smallLabel2.Name = "smallLabel2";
            smallLabel2.Size = new Size(40, 21);
            smallLabel2.TabIndex = 11;
            smallLabel2.Text = "Tipo";
            // 
            // smallLabel3
            // 
            smallLabel3.AutoSize = true;
            smallLabel3.BackColor = Color.Transparent;
            smallLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel3.ForeColor = Color.White;
            smallLabel3.Location = new Point(2, 111);
            smallLabel3.Name = "smallLabel3";
            smallLabel3.Size = new Size(78, 21);
            smallLabel3.TabIndex = 12;
            smallLabel3.Text = "Ubicacion";
            // 
            // smallLabel4
            // 
            smallLabel4.AutoSize = true;
            smallLabel4.BackColor = Color.Transparent;
            smallLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel4.ForeColor = Color.White;
            smallLabel4.Location = new Point(12, 151);
            smallLabel4.Name = "smallLabel4";
            smallLabel4.Size = new Size(56, 21);
            smallLabel4.TabIndex = 13;
            smallLabel4.Text = "Estado";
            // 
            // smallLabel5
            // 
            smallLabel5.AutoSize = true;
            smallLabel5.BackColor = Color.Transparent;
            smallLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel5.ForeColor = Color.White;
            smallLabel5.Location = new Point(10, 196);
            smallLabel5.Name = "smallLabel5";
            smallLabel5.Size = new Size(53, 21);
            smallLabel5.TabIndex = 14;
            smallLabel5.Text = "Marca";
            // 
            // smallLabel6
            // 
            smallLabel6.AutoSize = true;
            smallLabel6.BackColor = Color.Transparent;
            smallLabel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel6.ForeColor = Color.White;
            smallLabel6.Location = new Point(9, 246);
            smallLabel6.Name = "smallLabel6";
            smallLabel6.Size = new Size(63, 21);
            smallLabel6.TabIndex = 15;
            smallLabel6.Text = "Modelo";
            // 
            // smallLabel7
            // 
            smallLabel7.AutoSize = true;
            smallLabel7.BackColor = Color.Transparent;
            smallLabel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel7.ForeColor = Color.White;
            smallLabel7.Location = new Point(9, 297);
            smallLabel7.Name = "smallLabel7";
            smallLabel7.Size = new Size(45, 21);
            smallLabel7.TabIndex = 16;
            smallLabel7.Text = "Serie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(700, 338);
            Controls.Add(smallLabel7);
            Controls.Add(smallLabel6);
            Controls.Add(smallLabel5);
            Controls.Add(smallLabel4);
            Controls.Add(smallLabel3);
            Controls.Add(smallLabel2);
            Controls.Add(smallLabel1);
            Controls.Add(btnVerManteniemintos);
            Controls.Add(txtSerie);
            Controls.Add(dgvEquipos);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(cmbEstado);
            Controls.Add(cmbUbicacion);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cmbTipo);
            Controls.Add(txtCodigo);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtCodigo;
        private ReaLTaiizor.Controls.ForeverComboBox cmbTipo;
        private ReaLTaiizor.Controls.HopeTextBox txtMarca;
        private ReaLTaiizor.Controls.HopeTextBox txtModelo;
        private ReaLTaiizor.Controls.ForeverComboBox cmbUbicacion;
        private ReaLTaiizor.Controls.ForeverComboBox cmbEstado;
        private ReaLTaiizor.Controls.NightButton btnAgregarEquipo;
        private DataGridView dgvEquipos;
        private ReaLTaiizor.Controls.HopeTextBox txtSerie;
        private ReaLTaiizor.Controls.NightButton btnVerManteniemintos;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallLabel smallLabel2;
        private ReaLTaiizor.Controls.SmallLabel smallLabel3;
        private ReaLTaiizor.Controls.SmallLabel smallLabel4;
        private ReaLTaiizor.Controls.SmallLabel smallLabel5;
        private ReaLTaiizor.Controls.SmallLabel smallLabel6;
        private ReaLTaiizor.Controls.SmallLabel smallLabel7;
    }
}
