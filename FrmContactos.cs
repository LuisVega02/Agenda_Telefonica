using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmContactos : Form
    {
        string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        public FrmContactos()
        {
            InitializeComponent();
            CargarContactos();
        }

        private void CargarContactos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerContactos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar solo las columnas deseadas
                dgvContactos.DataSource = dt;

                // Ocultar columnas no necesarias
                dgvContactos.Columns["Id"].Visible = false;
                dgvContactos.Columns["CategoriaNombre"].Visible = false;

                // Ajustar encabezados
                dgvContactos.Columns["Numero"].HeaderText = "Número";
                dgvContactos.Columns["NombreCompleto"].HeaderText = "Nombre";
                dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }


        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            FrmContactoDetalle detalle = new FrmContactoDetalle();
            detalle.FormClosed += (s, args) => CargarContactos();
            detalle.ShowDialog();
        }

        private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idContacto = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
                FrmContactoDetalle detalle = new FrmContactoDetalle(idContacto);
                detalle.FormClosed += (s, args) => CargarContactos();
                detalle.ShowDialog();
            }
        }
    }

}
