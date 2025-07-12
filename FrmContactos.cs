using System.Data;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public partial class FrmContactos : Form
    {
        private string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        // Colores personalizados
        private Color colorGuinda = Color.FromArgb(123, 31, 62);
        private Color colorFondoPastel = Color.FromArgb(253, 245, 245);
        private Color colorTexto = Color.FromArgb(64, 64, 64);

        public FrmContactos()
        {
            InitializeComponent();
            ApplyModernStyle();
            CargarContactos();
        }

        private void ApplyModernStyle()
        {
            // Estilo del formulario
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            // Estilo del DataGridView
            dgvContactos.BackgroundColor = colorFondoPastel;
            dgvContactos.BorderStyle = BorderStyle.None;
            dgvContactos.EnableHeadersVisualStyles = false;
            dgvContactos.ColumnHeadersDefaultCellStyle.BackColor = colorGuinda;
            dgvContactos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvContactos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dgvContactos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvContactos.RowHeadersVisible = false;
            dgvContactos.DefaultCellStyle.BackColor = colorFondoPastel;
            dgvContactos.DefaultCellStyle.ForeColor = colorTexto;
            dgvContactos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, colorGuinda);
            dgvContactos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvContactos.GridColor = Color.FromArgb(230, 230, 230);
            dgvContactos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void CargarContactos(bool soloFavoritos = false)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = soloFavoritos ?
                    "SELECT c.Id, c.Numero, c.Nombres, c.Apellidos, c.Nombres + ' ' + c.Apellidos AS NombreCompleto, c.Correo, c.Direccion, c.CategoriaId, cat.Nombre AS CategoriaNombre, c.EsFavorito " +
                    "FROM Contactos c INNER JOIN Categorias cat ON c.CategoriaId = cat.Id " +
                    "WHERE c.EsFavorito = 1" :
                    "sp_ObtenerContactos";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvContactos.DataSource = dt;

                    // Ocultar columnas no necesarias
                    dgvContactos.Columns["Id"].Visible = false;
                    dgvContactos.Columns["CategoriaId"].Visible = false;
                    dgvContactos.Columns["CategoriaNombre"].Visible = false;

                    // Ajustar encabezados
                    dgvContactos.Columns["Numero"].HeaderText = "Número";
                    dgvContactos.Columns["NombreCompleto"].HeaderText = "Nombre";

                    // Configurar columna de favoritos
                    if (dgvContactos.Columns.Contains("EsFavorito"))
                    {
                        dgvContactos.Columns["EsFavorito"].HeaderText = "Favorito";
                        dgvContactos.Columns["EsFavorito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
                else
                {
                    dgvContactos.DataSource = null;
                }
            }
        }
        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContactos.Columns["EsFavorito"].Index && e.RowIndex >= 0)
            {
                int idContacto = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_AlternarFavorito", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", idContacto);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Refrescar la lista
                CargarContactos(chkFavoritos1.Checked);
            }
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            FrmContactoDetalle detalle = new FrmContactoDetalle();
            detalle.FormClosed += (s, args) => CargarContactos(chkFavoritos1.Checked);
            detalle.ShowDialog();
        }

        private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0) // No es la columna de favoritos
            {
                int idContacto = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
                FrmContactoDetalle detalle = new FrmContactoDetalle(idContacto);
                detalle.FormClosed += (s, args) => CargarContactos(chkFavoritos1.Checked);
                detalle.ShowDialog();
            }
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Es la columna de favoritos
            {
                int idContacto = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
                bool esFavorito = Convert.ToBoolean(dgvContactos.Rows[e.RowIndex].Cells["EsFavorito"].Value);

                ToggleFavorito(idContacto, !esFavorito);
                CargarContactos(chkFavoritos1.Checked);
            }
        }

        private void ToggleFavorito(int idContacto, bool esFavorito)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Contactos SET EsFavorito = @EsFavorito WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idContacto);
                cmd.Parameters.AddWithValue("@EsFavorito", esFavorito);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FrmImportarCSV importarForm = new FrmImportarCSV();
            importarForm.FormClosed += (s, args) => CargarContactos(chkFavoritos1.Checked);
            importarForm.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FrmExportarCSV exportarForm = new FrmExportarCSV();
            exportarForm.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias();
            frm.ShowDialog();
            CargarContactos(chkFavoritos1.Checked);
        }


        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            chkFavoritos1.Checked = !chkFavoritos1.Checked;
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            // Asegurar que el DataGridView tenga el tamaño correcto
            dgvContactos.Height = this.ClientSize.Height - 70;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (dgvContactos != null)
            {
                dgvContactos.Height = this.ClientSize.Height - panelToolbar.Height - 20;
                dgvContactos.Width = this.ClientSize.Width - 40;
                dgvContactos.Location = new Point(20, panelToolbar.Height + 10);
            }
        }

        private void chkFavoritos1_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarContactos(chkFavoritos1.Checked);
        }
    }
}