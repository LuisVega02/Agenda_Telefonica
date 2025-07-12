using System.Data;
using System.Data.SqlClient;

namespace AgendaTelefonica
{
    public partial class FrmContactoDetalle : Form
    {
        private int? contactoId = null;
        private string connectionString = "Server=.;Database=ContactosDB;Trusted_Connection=True;";
        private byte[] fotoPerfilBytes = null;

        public FrmContactoDetalle(int? id = null)
        {
            InitializeComponent();
            contactoId = id;
            CargarCategorias();
            if (contactoId.HasValue) CargarDatos();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F);

            // Estilo para los TextBox
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    var txt = (TextBox)ctrl;
                    txt.BackColor = Color.FromArgb(253, 245, 245);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.ForeColor = Color.FromArgb(64, 64, 64);
                }
                else if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl;
                    cmb.BackColor = Color.FromArgb(253, 245, 245);
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.ForeColor = Color.FromArgb(64, 64, 64);
                }
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
                    chkFavorito.Checked = Convert.ToBoolean(reader["EsFavorito"]);

                    // Cargar foto de perfil si existe
                    if (reader["FotoPerfil"] != DBNull.Value)
                    {
                        fotoPerfilBytes = (byte[])reader["FotoPerfil"];
                        using (MemoryStream ms = new MemoryStream(fotoPerfilBytes))
                        {
                            picFotoPerfil.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar Foto de Perfil";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Leer la imagen seleccionada
                        Image imagen = Image.FromFile(openFileDialog.FileName);

                        // Redimensionar si es muy grande (opcional)
                        if (imagen.Width > 500 || imagen.Height > 500)
                        {
                            imagen = RedimensionarImagen(imagen, 500, 500);
                        }

                        // Mostrar en el PictureBox
                        picFotoPerfil.Image = imagen;

                        // Convertir a bytes para guardar en la base de datos
                        using (MemoryStream ms = new MemoryStream())
                        {
                            imagen.Save(ms, imagen.RawFormat);
                            fotoPerfilBytes = ms.ToArray();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Image RedimensionarImagen(Image imagen, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / imagen.Width;
            var ratioY = (double)maxHeight / imagen.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(imagen.Width * ratio);
            var newHeight = (int)(imagen.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(imagen, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            picFotoPerfil.Image = null;
            fotoPerfilBytes = null;
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
                cmd.Parameters.AddWithValue("@EsFavorito", chkFavorito.Checked);

                // Agregar parámetro para la foto de perfil
                if (fotoPerfilBytes != null && fotoPerfilBytes.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@FotoPerfil", fotoPerfilBytes);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FotoPerfil", DBNull.Value);
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            this.Close();
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

        private void FrmContactoDetalle_Load(object sender, EventArgs e)
        {

        }
    }

}
