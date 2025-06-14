namespace AgendaTelefonica
{
    partial class FrmContactos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContactos = new DataGridView();
            btnNuevoContacto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(12, 12);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.Size = new Size(776, 426);
            dgvContactos.TabIndex = 0;
            dgvContactos.CellDoubleClick += dgvContactos_CellDoubleClick;
            // 
            // btnNuevoContacto
            // 
            btnNuevoContacto.Location = new Point(694, 12);
            btnNuevoContacto.Name = "btnNuevoContacto";
            btnNuevoContacto.Size = new Size(94, 29);
            btnNuevoContacto.TabIndex = 1;
            btnNuevoContacto.Text = "Nuevo Contacto";
            btnNuevoContacto.UseVisualStyleBackColor = true;
            btnNuevoContacto.Click += btnNuevoContacto_Click;
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoContacto);
            Controls.Add(dgvContactos);
            Name = "FrmContactos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContactos;
        private Button btnNuevoContacto;
    }
}
