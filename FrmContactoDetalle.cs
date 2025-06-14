using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmContactoDetalle : Form
    {
        private int? contactoId = null;
        string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";

        public FrmContactoDetalle(int? id = null)
        {
            InitializeComponent();
            contactoId = id;
            CargarCategorias();
            if (contactoId.HasValue) CargarDatos();
        }

        private void CargarCategorias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Categorias", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategoria.DataSource = dt;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "Id";
            }
        }

        private void CargarDatos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Contactos WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", contactoId.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNumero.Text = reader["Numero"].ToString();
                    txtNombres.Text = reader["Nombres"].ToString();
                    txtApellidos.Text = reader["Apellidos"].ToString();
                    txtCorreo.Text = reader["Correo"].ToString();
                    txtDireccion.Text = reader["Direccion"].ToString();
                    cmbCategoria.SelectedValue = Convert.ToInt32(reader["CategoriaId"]);
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                if (contactoId.HasValue)
                {
                    cmd.CommandText = "sp_ActualizarContacto";
                    cmd.Parameters.AddWithValue("@Id", contactoId.Value);
                }
                else
                {
                    cmd.CommandText = "sp_InsertarContacto";
                }

                cmd.Parameters.AddWithValue("@Numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@CategoriaId", cmbCategoria.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            this.Close(); // Cierra y vuelve al formulario principal
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (!contactoId.HasValue) return;

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este contacto?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarContacto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", contactoId.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                this.Close();
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
