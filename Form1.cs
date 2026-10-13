namespace Avance1_KendallCampos
{
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (txtNombre.Text.Trim() == "" ||
                txtIdentificacion.Text.Trim() == "" ||
                txtEdad.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                cmbCarrera.SelectedIndex == -1 ||
                cmbBloque.SelectedIndex == -1)
            {
                MessageBox.Show(
            "Debe completar todos los datos del estudiante.",
            "Advertencia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                return;
            }
            // Verificar que la edad sea válida
            if (!int.TryParse(txtEdad.Text, out int edad) ||
                edad < 1 || edad > 120)
            {
                MessageBox.Show(
            "Ingrese una edad válida.",
            "Advertencia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                return;
            }
            // Verificar que el bloque sea válido
            if (!int.TryParse(cmbBloque.Text.Replace("Bloque ", ""), out int bloque) ||
                bloque < 1 || bloque > 9)
            {
                MessageBox.Show(
            "Seleccione un bloque válido.",
            "Advertencia",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                return;
            }
            // Confirmar que los datos fueron validados
            MessageBox.Show(
                "Datos validados correctamente. El registro en la base de datos se implementará posteriormente.",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();

            // Quitar la selección de carrera y bloque
            cmbCarrera.SelectedIndex = -1;
            cmbBloque.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario
            this.Close();
        }
    }
}
