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
            txtCodigo.Location = new Point(127, 39);
            txtCodigo.MaxLength = 32767;
            txtCodigo.Multiline = false;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.ScrollBars = ScrollBars.None;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.Size = new Size(94, 43);
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
            cmbTipo.Location = new Point(104, 162);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 24);
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
            txtMarca.Location = new Point(67, 386);
            txtMarca.MaxLength = 32767;
            txtMarca.Multiline = false;
            txtMarca.Name = "txtMarca";
            txtMarca.PasswordChar = '\0';
            txtMarca.ScrollBars = ScrollBars.None;
            txtMarca.SelectedText = "";
            txtMarca.SelectionLength = 0;
            txtMarca.SelectionStart = 0;
            txtMarca.Size = new Size(99, 43);
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
            txtModelo.Location = new Point(229, 386);
            txtModelo.MaxLength = 32767;
            txtModelo.Multiline = false;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.ScrollBars = ScrollBars.None;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.Size = new Size(110, 43);
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
            cmbUbicacion.Items.AddRange(new object[] { "Laptop", "Impresora", "Mouse", "Teclado" });
            cmbUbicacion.Location = new Point(104, 238);
            cmbUbicacion.Name = "cmbUbicacion";
            cmbUbicacion.Size = new Size(151, 24);
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
            cmbEstado.Items.AddRange(new object[] { "Laptop", "Impresora", "Mouse", "Teclado" });
            cmbEstado.Location = new Point(104, 319);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 24);
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
            btnAgregarEquipo.Location = new Point(537, 272);
            btnAgregarEquipo.MinimumSize = new Size(144, 47);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.NormalBackColor = Color.Cyan;
            btnAgregarEquipo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAgregarEquipo.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnAgregarEquipo.PressedForeColor = Color.FromArgb(0, 192, 192);
            btnAgregarEquipo.Radius = 20;
            btnAgregarEquipo.Size = new Size(180, 59);
            btnAgregarEquipo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnAgregarEquipo.TabIndex = 6;
            btnAgregarEquipo.Text = "AGREGAR EQUIPO";
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(442, 39);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(300, 188);
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
            txtSerie.Location = new Point(386, 386);
            txtSerie.MaxLength = 32767;
            txtSerie.Multiline = false;
            txtSerie.Name = "txtSerie";
            txtSerie.PasswordChar = '\0';
            txtSerie.ScrollBars = ScrollBars.None;
            txtSerie.SelectedText = "";
            txtSerie.SelectionLength = 0;
            txtSerie.SelectionStart = 0;
            txtSerie.Size = new Size(93, 43);
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
            btnVerManteniemintos.Location = new Point(537, 370);
            btnVerManteniemintos.MinimumSize = new Size(144, 47);
            btnVerManteniemintos.Name = "btnVerManteniemintos";
            btnVerManteniemintos.NormalBackColor = Color.Cyan;
            btnVerManteniemintos.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnVerManteniemintos.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btnVerManteniemintos.PressedForeColor = Color.White;
            btnVerManteniemintos.Radius = 20;
            btnVerManteniemintos.Size = new Size(180, 59);
            btnVerManteniemintos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnVerManteniemintos.TabIndex = 9;
            btnVerManteniemintos.Text = "MANTENIMIENTOS";
            btnVerManteniemintos.Click += btnVerManteniemintos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
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
    }
}
