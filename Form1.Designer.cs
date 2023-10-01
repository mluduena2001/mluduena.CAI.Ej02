namespace mluduena.CAI.Ej02
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
            lblMarca = new Label();
            cmbMarcas = new ComboBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            lblAño = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lstDatosAuto = new ListBox();
            lblNombreUsuario = new Label();
            lblNombreReal = new Label();
            lblFechaHoy = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(143, 77);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // cmbMarcas
            // 
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Location = new Point(143, 95);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(121, 23);
            cmbMarcas.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(143, 135);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(143, 153);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(121, 23);
            txtModelo.TabIndex = 3;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(143, 214);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(121, 23);
            txtAño.TabIndex = 5;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(143, 196);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 4;
            lblAño.Text = "Año:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(143, 277);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(143, 259);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // lstDatosAuto
            // 
            lstDatosAuto.FormattingEnabled = true;
            lstDatosAuto.ItemHeight = 15;
            lstDatosAuto.Location = new Point(308, 95);
            lstDatosAuto.Name = "lstDatosAuto";
            lstDatosAuto.Size = new Size(120, 94);
            lstDatosAuto.TabIndex = 8;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(12, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(109, 15);
            lblNombreUsuario.TabIndex = 9;
            lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblNombreReal
            // 
            lblNombreReal.AutoSize = true;
            lblNombreReal.Location = new Point(12, 33);
            lblNombreReal.Name = "lblNombreReal";
            lblNombreReal.Size = new Size(131, 15);
            lblNombreReal.TabIndex = 10;
            lblNombreReal.Text = "Nombre de usuario real";
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Location = new Point(12, 57);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(73, 15);
            lblFechaHoy.TabIndex = 11;
            lblFechaHoy.Text = "Fecha actual";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(143, 320);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += ingresarDatosClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(lblFechaHoy);
            Controls.Add(lblNombreReal);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lstDatosAuto);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtAño);
            Controls.Add(lblAño);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(cmbMarcas);
            Controls.Add(lblMarca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private ComboBox cmbMarcas;
        private Label lblModelo;
        private TextBox txtModelo;
        private TextBox txtAño;
        private Label lblAño;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private ListBox lstDatosAuto;
        private Label lblNombreUsuario;
        private Label lblNombreReal;
        private Label lblFechaHoy;
        private Button btnIngresar;
    }
}