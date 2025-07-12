namespace AgendaTelefonica
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // Estilo ya aplicado en el diseñador
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Credenciales de prueba (en una aplicación real, esto vendría de una base de datos)
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                // Ocultar el formulario de login
                this.Hide();

                // Crear y mostrar el formulario principal
                FrmContactos formContactos = new FrmContactos();
                formContactos.Show();

                // Cerrar el formulario de login cuando se cierre el principal
                formContactos.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error de autenticación",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}