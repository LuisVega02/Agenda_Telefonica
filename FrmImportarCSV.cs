using System.Data;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public partial class FrmImportarCSV : Form
    {
        private string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        public FrmImportarCSV()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // Estilo del DataGridView
            dgvPreview.EnableHeadersVisualStyles = false;
            dgvPreview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 62);
            dgvPreview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPreview.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPreview.DefaultCellStyle.BackColor = Color.FromArgb(253, 245, 245);
            dgvPreview.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvPreview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 123, 31, 62);
            dgvPreview.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPreview.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Archivos CSV (*.csv)|*.csv";
                openFile.Title = "Seleccionar archivo CSV";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFile.FileName;
                        DataTable dt = new DataTable();

                        // Configurar columnas del DataTable
                        dt.Columns.Add("NombreCompleto");
                        dt.Columns.Add("Numero");
                        dt.Columns.Add("Correo");
                        dt.Columns.Add("Direccion");
                        dt.Columns.Add("CategoriaId");

                        // Leer archivo CSV (omitir la primera línea si es encabezado)
                        var lines = File.ReadAllLines(filePath).Skip(1);

                        foreach (string line in lines)
                        {
                            // Manejar comillas y separadores
                            string[] datos = ParseCsvLine(line);

                            if (datos.Length >= 5)
                            {
                                dt.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                            }
                        }

                        dgvPreview.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string[] ParseCsvLine(string line)
        {
            // Manejo básico de comillas en CSV
            return line.Split(new[] { ',' }, StringSplitOptions.None)
                      .Select(s => s.Trim('"')).ToArray();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvPreview.Rows.Count == 0 || dgvPreview.DataSource == null)
            {
                MessageBox.Show("No hay datos para importar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvPreview.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string nombreCompleto = row.Cells["NombreCompleto"].Value?.ToString() ?? "";
                        string numero = row.Cells["Numero"].Value?.ToString() ?? "";
                        string correo = row.Cells["Correo"].Value?.ToString() ?? "";
                        string direccion = row.Cells["Direccion"].Value?.ToString() ?? "";
                        int categoriaId = Convert.ToInt32(row.Cells["CategoriaId"].Value ?? 1);

                        // Separar nombres y apellidos
                        string[] partes = nombreCompleto.Split(' ');
                        string nombres = partes.Length > 1 ? string.Join(" ", partes, 0, partes.Length - 1) : nombreCompleto;
                        string apellidos = partes.Length > 1 ? partes[^1] : "";

                        using (SqlCommand cmd = new SqlCommand("sp_InsertarContacto", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Numero", numero);
                            cmd.Parameters.AddWithValue("@Nombres", nombres);
                            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                            cmd.Parameters.AddWithValue("@Correo", correo);
                            cmd.Parameters.AddWithValue("@Direccion", direccion);
                            cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Contactos importados correctamente", "Importación exitosa",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al importar contactos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}