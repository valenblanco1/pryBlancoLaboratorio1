namespace pryBlancoLaboratorio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GroupBox grpDatos;
        private GroupBox grpPlan;
        private GroupBox grpPago;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlan;
        private Label lblTurno;
        private Label lblMeses;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkEstudiante;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtMeses;
        private CheckBox chkCasillero;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox grpConsultas;
        private Label lblBuscarNombre;
        private TextBox txtBuscarNombre;
        private TextBox txtResultadoBusqueda;
        private Button btnBuscar;
        private Panel pnlEncabezado;
        private Label lblTitulo;
        private Label lblSubtitulo;

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
            components = new System.ComponentModel.Container();
            grpDatos = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            chkEstudiante = new CheckBox();
            grpPlan = new GroupBox();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblTurno = new Label();
            cboTurno = new ComboBox();
            lblMeses = new Label();
            txtMeses = new TextBox();
            chkCasillero = new CheckBox();
            grpPago = new GroupBox();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            cboCuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpConsultas = new GroupBox();
            lblBuscarNombre = new Label();
            txtBuscarNombre = new TextBox();
            txtResultadoBusqueda = new TextBox();
            btnBuscar = new Button();
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpDatos.SuspendLayout();
            grpPlan.SuspendLayout();
            grpPago.SuspendLayout();
            grpConsultas.SuspendLayout();
            SuspendLayout();

            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(chkEstudiante);
            grpDatos.Location = new Point(20, 78);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(530, 115);
            grpDatos.BackColor = Color.White;
            grpDatos.ForeColor = Color.FromArgb(31, 56, 100);
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos personales";

            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 30);
            lblNombre.Text = "Nombre:";
            txtNombre.Location = new Point(100, 27);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.TextChanged += Datos_TextChanged;

            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(20, 65);
            lblEdad.Text = "Edad:";
            txtEdad.Location = new Point(100, 62);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(70, 23);
            txtEdad.TabIndex = 1;
            txtEdad.KeyPress += SoloDigitos_KeyPress;
            txtEdad.TextChanged += Datos_TextChanged;

            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(210, 64);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Text = "Estudiante";

            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Location = new Point(20, 208);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(530, 145);
            grpPlan.BackColor = Color.White;
            grpPlan.ForeColor = Color.FromArgb(31, 56, 100);
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan y adicionales";

            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(20, 30);
            lblPlan.Text = "Plan:";
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" });
            cboPlan.Location = new Point(100, 27);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(180, 23);
            cboPlan.TabIndex = 3;

            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(300, 30);
            lblTurno.Text = "Turno:";
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(360, 27);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(145, 23);
            cboTurno.TabIndex = 4;

            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(20, 70);
            lblMeses.Text = "Meses:";
            txtMeses.Location = new Point(100, 67);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(70, 23);
            txtMeses.TabIndex = 5;
            txtMeses.KeyPress += SoloDigitos_KeyPress;
            txtMeses.TextChanged += Datos_TextChanged;

            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(210, 69);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Text = "Casillero ($ 3.000/mes)";

            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Controls.Add(cboCuotas);
            grpPago.Location = new Point(20, 368);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(530, 85);
            grpPago.BackColor = Color.White;
            grpPago.ForeColor = Color.FromArgb(31, 56, 100);
            grpPago.TabStop = false;
            grpPago.Text = "Forma de pago";

            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(25, 35);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;

            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(145, 35);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;

            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(260, 32);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(100, 23);
            cboCuotas.TabIndex = 8;

            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(290, 473);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 35);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "&Calcular";
            btnCalcular.BackColor = Color.SeaGreen;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;

            btnLimpiar.Location = new Point(430, 473);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.BackColor = Color.DarkOrange;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            grpConsultas.Controls.Add(lblBuscarNombre);
            grpConsultas.Controls.Add(txtBuscarNombre);
            grpConsultas.Controls.Add(txtResultadoBusqueda);
            grpConsultas.Controls.Add(btnBuscar);
            grpConsultas.Location = new Point(20, 523);
            grpConsultas.Name = "grpConsultas";
            grpConsultas.Size = new Size(530, 145);
            grpConsultas.BackColor = Color.White;
            grpConsultas.ForeColor = Color.FromArgb(31, 56, 100);
            grpConsultas.TabStop = false;
            grpConsultas.Text = "Buscar socio ingresado";

            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Location = new Point(20, 29);
            lblBuscarNombre.Text = "Nombre:";

            txtBuscarNombre.Location = new Point(82, 25);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(290, 23);
            txtBuscarNombre.CharacterCasing = CharacterCasing.Upper;
            txtBuscarNombre.KeyPress += txtNombre_KeyPress;

            txtResultadoBusqueda.Location = new Point(20, 62);
            txtResultadoBusqueda.Multiline = true;
            txtResultadoBusqueda.Name = "txtResultadoBusqueda";
            txtResultadoBusqueda.ReadOnly = true;
            txtResultadoBusqueda.ScrollBars = ScrollBars.Vertical;
            txtResultadoBusqueda.Size = new Size(490, 65);
            txtResultadoBusqueda.TabStop = false;
            txtResultadoBusqueda.BackColor = Color.FromArgb(245, 248, 252);
            txtResultadoBusqueda.ForeColor = Color.FromArgb(45, 45, 45);

            btnBuscar.Location = new Point(385, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 30);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            pnlEncabezado.BackColor = Color.FromArgb(31, 78, 121);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(575, 62);

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 7);
            lblTitulo.Text = "GIMNASIO SIGLO";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(220, 235, 250);
            lblSubtitulo.Location = new Point(22, 37);
            lblSubtitulo.Text = "Inscripción de socios · Calculá tu plan";

            AutoScaleMode = AutoScaleMode.Font;
            AcceptButton = btnCalcular;
            BackColor = Color.FromArgb(225, 235, 247);
            ClientSize = new Size(575, 688);
            Font = new Font("Segoe UI", 9F);
            Controls.Add(pnlEncabezado);
            Controls.Add(grpDatos);
            Controls.Add(grpPlan);
            Controls.Add(grpPago);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(grpConsultas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo — Inscripción";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            grpConsultas.ResumeLayout(false);
            grpConsultas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
