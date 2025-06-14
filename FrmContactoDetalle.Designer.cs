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
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(234, 208);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(234, 274);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 27);
            txtApellidos.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(234, 241);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 27);
            txtNombres.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(234, 340);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(234, 307);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(234, 373);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(542, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(542, 82);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(542, 47);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 376);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 9;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 343);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 10;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 310);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 11;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 277);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 211);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 13;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 244);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "Nombres";
            // 
            // FrmContactoDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 413);
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
            Name = "FrmContactoDetalle";
            Text = "FrmContactoDetalle";
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
    }
}