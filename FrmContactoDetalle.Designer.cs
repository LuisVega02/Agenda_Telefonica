namespace AgendaTelefonica
{
    partial class FrmContactoDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            cmbCategoria = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkFavorito = new CheckBox();
            picFotoPerfil = new PictureBox();
            btnSeleccionarFoto = new Button();
            btnEliminarFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)picFotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(253, 245, 245);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumero.Location = new Point(205, 40);
            txtNumero.Margin = new Padding(3, 10, 3, 10);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(200, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(253, 245, 245);
            txtApellidos.BorderStyle = BorderStyle.FixedSingle;
            txtApellidos.ForeColor = Color.FromArgb(64, 64, 64);
            txtApellidos.Location = new Point(205, 100);
            txtApellidos.Margin = new Padding(3, 10, 3, 10);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(200, 23);
            txtApellidos.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.FromArgb(253, 245, 245);
            txtNombres.BorderStyle = BorderStyle.FixedSingle;
            txtNombres.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombres.Location = new Point(205, 70);
            txtNombres.Margin = new Padding(3, 10, 3, 10);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(200, 23);
            txtNombres.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(253, 245, 245);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDireccion.Location = new Point(205, 160);
            txtDireccion.Margin = new Padding(3, 10, 3, 10);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(253, 245, 245);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            txtCorreo.Location = new Point(205, 130);
            txtCorreo.Margin = new Padding(3, 10, 3, 10);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 23);
            txtCorreo.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(253, 245, 245);
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.ForeColor = Color.FromArgb(64, 64, 64);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(205, 190);
            cmbCategoria.Margin = new Padding(3, 10, 3, 10);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 23);
            cmbCategoria.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(123, 31, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(430, 40);
            btnGuardar.Margin = new Padding(3, 10, 20, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 30);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(253, 245, 245);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.FromArgb(123, 31, 62);
            btnEliminar.Location = new Point(430, 130);
            btnEliminar.Margin = new Padding(3, 10, 20, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 30);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(253, 245, 245);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(123, 31, 62);
            btnCancelar.Location = new Point(430, 85);
            btnCancelar.Margin = new Padding(3, 10, 20, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(135, 193);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 9;
            label1.Text = "Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(135, 163);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(135, 133);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 11;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(135, 103);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(135, 43);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(135, 73);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "Nombres";
            // 
            // chkFavorito
            // 
            chkFavorito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkFavorito.Appearance = Appearance.Button;
            chkFavorito.BackColor = Color.FromArgb(253, 245, 245);
            chkFavorito.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            chkFavorito.FlatAppearance.CheckedBackColor = Color.FromArgb(123, 31, 62);
            chkFavorito.FlatStyle = FlatStyle.Flat;
            chkFavorito.Font = new Font("Segoe UI", 9F);
            chkFavorito.ForeColor = Color.FromArgb(123, 31, 62);
            chkFavorito.Location = new Point(478, 180);
            chkFavorito.Margin = new Padding(3, 10, 20, 10);
            chkFavorito.Name = "chkFavorito";
            chkFavorito.Size = new Size(31, 30);
            chkFavorito.TabIndex = 15;
            chkFavorito.Text = "(  )";
            chkFavorito.TextAlign = ContentAlignment.MiddleCenter;
            chkFavorito.UseVisualStyleBackColor = false;
            // 
            // picFotoPerfil
            // 
            picFotoPerfil.BackColor = Color.FromArgb(253, 245, 245);
            picFotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            picFotoPerfil.Location = new Point(20, 40);
            picFotoPerfil.Name = "picFotoPerfil";
            picFotoPerfil.Size = new Size(100, 100);
            picFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoPerfil.TabIndex = 16;
            picFotoPerfil.TabStop = false;
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.BackColor = Color.FromArgb(253, 245, 245);
            btnSeleccionarFoto.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnSeleccionarFoto.FlatStyle = FlatStyle.Flat;
            btnSeleccionarFoto.Font = new Font("Segoe UI", 8F);
            btnSeleccionarFoto.ForeColor = Color.FromArgb(123, 31, 62);
            btnSeleccionarFoto.Location = new Point(20, 150);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(100, 25);
            btnSeleccionarFoto.TabIndex = 17;
            btnSeleccionarFoto.Text = "Seleccionar Foto";
            btnSeleccionarFoto.UseVisualStyleBackColor = false;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // btnEliminarFoto
            // 
            btnEliminarFoto.BackColor = Color.FromArgb(253, 245, 245);
            btnEliminarFoto.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnEliminarFoto.FlatStyle = FlatStyle.Flat;
            btnEliminarFoto.Font = new Font("Segoe UI", 8F);
            btnEliminarFoto.ForeColor = Color.FromArgb(123, 31, 62);
            btnEliminarFoto.Location = new Point(20, 180);
            btnEliminarFoto.Name = "btnEliminarFoto";
            btnEliminarFoto.Size = new Size(100, 25);
            btnEliminarFoto.TabIndex = 18;
            btnEliminarFoto.Text = "Eliminar Foto";
            btnEliminarFoto.UseVisualStyleBackColor = false;
            btnEliminarFoto.Click += btnEliminarFoto_Click;
            // 
            // FrmContactoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 250);
            Controls.Add(btnEliminarFoto);
            Controls.Add(btnSeleccionarFoto);
            Controls.Add(picFotoPerfil);
            Controls.Add(chkFavorito);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombres);
            Controls.Add(txtApellidos);
            Controls.Add(txtNumero);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(616, 289);
            Name = "FrmContactoDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Contacto";
            Load += FrmContactoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)picFotoPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private ComboBox cmbCategoria;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkFavorito;
        private PictureBox picFotoPerfil;
        private Button btnSeleccionarFoto;
        private Button btnEliminarFoto;
    }
}