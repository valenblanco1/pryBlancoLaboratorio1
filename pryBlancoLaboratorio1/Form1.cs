namespace pryBlancoLaboratorio1
{
    public partial class Form1 : Form
    {
        private readonly List<(string Nombre, string Datos, string ResumenPlan)> sociosIngresados = new();
        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const int EDAD_MINIMA = 14;
        private const decimal RECARGO_SEIS_CUOTAS = 0.20m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void Datos_TextChanged(object? sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0 && txtEdad.Text.Length > 0 && txtMeses.Text.Length > 0)
                btnCalcular.Enabled = true;
            else
                btnCalcular.Enabled = false;
        }

        private void SoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void rbtTarjeta_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void rbtEfectivo_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbtEfectivo.Checked)
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            string nombreBuscado = txtBuscarNombre.Text.Trim();

            var resultados = sociosIngresados
                .Where(socio => nombreBuscado.Length == 0 || socio.Nombre.Contains(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                .Select(socio => socio.ResumenPlan)
                .ToList();

            if (resultados.Count == 0)
            {
                txtResultadoBusqueda.Text = nombreBuscado.Length == 0
                    ? "Todavía no hay socios ingresados."
                    : "No se encontró ningún socio con ese nombre.";
                return;
            }

            txtResultadoBusqueda.Text = $"Socios encontrados: {resultados.Count}\r\n" +
                                        string.Join("\r\n------------------------------\r\n", resultados);
        }

        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Meses inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string plan = cboPlan.SelectedItem?.ToString() ?? string.Empty;
            decimal precioMensual;
            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("El plan seleccionado no es válido.", "Plan inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            string horario;
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    horario = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    horario = "Noche (18 a 23 h)";
                    break;
                default:
                    horario = "No especificado";
                    break;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
            decimal subtotal = precioMensual * meses;
            decimal porcentajeDescuento;

            if (edad < 18)
                porcentajeDescuento = 0.25m;
            else
                if (edad >= 65)
                    porcentajeDescuento = 0.30m;
                else
                    if (chkEstudiante.Checked)
                        porcentajeDescuento = 0.15m;
                    else
                        porcentajeDescuento = 0m;

            decimal importeConDescuento = subtotal * (1 - porcentajeDescuento);
            decimal porcentajePago;
            int cuotas = 1;

            if (rbtEfectivo.Checked)
            {
                porcentajePago = -0.10m;
            }
            else
            {
                cuotas = int.Parse(cboCuotas.SelectedItem?.ToString() ?? "1");
                if (cuotas == 1)
                    porcentajePago = 0m;
                else if (cuotas == 3)
                    porcentajePago = 0.10m;
                else if (cuotas == 6)
                    porcentajePago = RECARGO_SEIS_CUOTAS;
                else
                    porcentajePago = 0m;
            }

            decimal total = importeConDescuento * (1 + porcentajePago);
            string categoria = edad < 18 ? "Menor" : "Mayor";
            string formaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cuotas} cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;
            string descuentoTexto = $"{porcentajeDescuento:P0}";
            string ajusteTexto = $"{porcentajePago:P0}";

            string detalle = $"SOCIO: {nombre}\n" +
                             $"Categoría: {categoria}\n" +
                             $"Plan: {plan}\n" +
                             $"Turno: {horario}\n" +
                             $"Meses: {meses}\n" +
                             $"Casillero: {(chkCasillero.Checked ? "Sí" : "No")}\n" +
                             $"Subtotal: {subtotal:C2}\n" +
                             $"Descuento por edad/estudiante: {descuentoTexto}\n" +
                             $"Ajuste por forma de pago: {ajusteTexto}\n" +
                             $"Forma de pago: {formaPago}\n" +
                             $"TOTAL: {total:C2}\n" +
                             $"Valor de cuota: {valorCuota:C2}";

            string resumenPlan = $"Socio: {nombre}\r\n" +
                                 $"Plan: {plan} | Precio mensual: {precioMensual:C2}\r\n" +
                                 $"Turno: {horario} | Duración: {meses} mes(es)\r\n" +
                                 $"Pago: {formaPago} | Total: {total:C2}";

            sociosIngresados.Add((nombre, detalle, resumenPlan));
            MessageBox.Show(detalle, "Detalle de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }
    }
}
