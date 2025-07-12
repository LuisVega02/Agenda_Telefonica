using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmExportarCSV : Form
    {
        private string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        public FrmExportarCSV()
        {
            InitializeComponent();
            ApplyModernStyle();
            CargarDatosExportacion();
        }

        private void ApplyModernStyle()
        {
            // Estilo del DataGridView
            dgvExport.EnableHeadersVisualStyles = false;
            dgvExport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 62);
            dgvExport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvExport.DefaultCellStyle.BackColor = Color.FromArgb(253, 245, 245);
            dgvExport.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvExport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 123, 31, 62);
            dgvExport.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvExport.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void CargarDatosExportacion()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT c.Nombres, c.Apellidos, c.Numero, c.Correo, c.Direccion, " +
                    "cat.Nombre AS Categoria, c.EsFavorito " +
                    "FROM Contactos c INNER JOIN Categorias cat ON c.CategoriaId = cat.Id",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvExport.DataSource = dt;

                // Configurar columnas
                dgvExport.Columns["EsFavorito"].HeaderText = "Favorito";
                dgvExport.Columns["Numero"].HeaderText = "Número";
            }
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Exportar contactos a CSV";
                saveFileDialog.FileName = "Contactos_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarACSV(saveFileDialog.FileName);
                    MessageBox.Show("Contactos exportados exitosamente", "Exportación completada",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportarACSV(string filePath)
        {
            // Crear el contenido CSV
            System.Text.StringBuilder csvContent = new System.Text.StringBuilder();

            // Agregar encabezados
            foreach (DataGridViewColumn column in dgvExport.Columns)
            {
                csvContent.Append(column.HeaderText + ",");
            }
            csvContent.AppendLine();

            // Agregar datos
            foreach (DataGridViewRow row in dgvExport.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csvContent.Append("\"" + cell.Value?.ToString()?.Replace("\"", "\"\"") + "\",");
                }
                csvContent.AppendLine();
            }

            // Guardar archivo
            System.IO.File.WriteAllText(filePath, csvContent.ToString(), System.Text.Encoding.UTF8);
        }

        private void FrmExportarCSV_Load_1(object sender, EventArgs e)
        {
            // Configuración adicional al cargar el formulario
        }

        
    }
}