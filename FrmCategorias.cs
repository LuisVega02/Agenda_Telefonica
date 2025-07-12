using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmCategorias : Form
    {
        private string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        public FrmCategorias()
        {
            InitializeComponent();
            ApplyModernStyle();
            CargarCategorias();
        }

        private void ApplyModernStyle()
        {
            // Estilo del DataGridView
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 62);
            dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvCategorias.DefaultCellStyle.BackColor = Color.FromArgb(253, 245, 245);
            dgvCategorias.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 123, 31, 62);
            dgvCategorias.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void CargarCategorias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre FROM Categorias", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Configurar columnas del DataGridView
                dgvCategorias.DataSource = dt;
                dgvCategorias.Columns["Id"].Visible = false;
                dgvCategorias.Columns["Nombre"].HeaderText = "Nombre de Categoría";
                dgvCategorias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la categoría", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Categorias (Nombre) VALUES (@Nombre)", conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtNombre.Clear();
            txtNombre.Focus();
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["Id"].Value);
            string nombre = dgvCategorias.SelectedRows[0].Cells["Nombre"].Value.ToString();

            var confirm = MessageBox.Show($"¿Está seguro de eliminar la categoría '{nombre}'?",
                                        "Confirmar Eliminación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Categorias WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    CargarCategorias();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"No se puede eliminar la categoría porque está en uso.\n\nError: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            // Enfocar el campo de texto al cargar el formulario
            txtNombre.Focus();
        }
    }
}