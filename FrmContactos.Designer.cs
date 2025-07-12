namespace AgendaTelefonica
{
    partial class FrmContactos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvContactos = new DataGridView();
            btnNuevoContacto = new Button();
            btnImport = new Button();
            btnExport = new Button();
            chkFavoritos1 = new CheckBox();
            btnCategorias = new Button();
            panelToolbar = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            panelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvContactos
            // 
            dgvContactos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContactos.BackgroundColor = Color.FromArgb(253, 245, 245);
            dgvContactos.BorderStyle = BorderStyle.None;
            dgvContactos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.GridColor = Color.FromArgb(230, 230, 230);
            dgvContactos.Location = new Point(20, 80);
            dgvContactos.Margin = new Padding(3, 10, 3, 10);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersVisible = false;
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(862, 510);
            dgvContactos.TabIndex = 0;
            dgvContactos.CellContentClick += dgvContactos_CellContentClick;
            dgvContactos.CellDoubleClick += dgvContactos_CellDoubleClick;
            // 
            // btnNuevoContacto
            // 
            btnNuevoContacto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoContacto.BackColor = Color.FromArgb(123, 31, 62);
            btnNuevoContacto.FlatAppearance.BorderSize = 0;
            btnNuevoContacto.FlatStyle = FlatStyle.Flat;
            btnNuevoContacto.Font = new Font("Segoe UI", 9F);
            btnNuevoContacto.ForeColor = Color.White;
            btnNuevoContacto.Location = new Point(620, 10);
            btnNuevoContacto.Margin = new Padding(3, 10, 3, 10);
            btnNuevoContacto.Name = "btnNuevoContacto";
            btnNuevoContacto.Size = new Size(120, 30);
            btnNuevoContacto.TabIndex = 1;
            btnNuevoContacto.Text = "Nuevo Contacto";
            btnNuevoContacto.UseVisualStyleBackColor = false;
            btnNuevoContacto.Click += btnNuevoContacto_Click;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.FromArgb(253, 245, 245);
            btnImport.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 9F);
            btnImport.ForeColor = Color.FromArgb(123, 31, 62);
            btnImport.Location = new Point(490, 10);
            btnImport.Margin = new Padding(3, 10, 10, 10);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(120, 30);
            btnImport.TabIndex = 2;
            btnImport.Text = "Importar";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(253, 245, 245);
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F);
            btnExport.ForeColor = Color.FromArgb(123, 31, 62);
            btnExport.Location = new Point(360, 10);
            btnExport.Margin = new Padding(3, 10, 10, 10);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 30);
            btnExport.TabIndex = 3;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // chkFavoritos1
            // 
            chkFavoritos1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkFavoritos1.Appearance = Appearance.Button;
            chkFavoritos1.BackColor = Color.FromArgb(253, 245, 245);
            chkFavoritos1.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            chkFavoritos1.FlatAppearance.CheckedBackColor = Color.FromArgb(123, 31, 62);
            chkFavoritos1.FlatStyle = FlatStyle.Flat;
            chkFavoritos1.Font = new Font("Segoe UI", 9F);
            chkFavoritos1.ForeColor = Color.FromArgb(123, 31, 62);
            chkFavoritos1.Location = new Point(230, 10);
            chkFavoritos1.Margin = new Padding(3, 10, 10, 10);
            chkFavoritos1.Name = "chkFavoritos1";
            chkFavoritos1.Size = new Size(120, 30);
            chkFavoritos1.TabIndex = 5;
            chkFavoritos1.Text = "Solo Favoritos";
            chkFavoritos1.TextAlign = ContentAlignment.MiddleCenter;
            chkFavoritos1.UseVisualStyleBackColor = false;
            chkFavoritos1.CheckedChanged += chkFavoritos1_CheckedChanged_1;
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCategorias.BackColor = Color.FromArgb(253, 245, 245);
            btnCategorias.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 9F);
            btnCategorias.ForeColor = Color.FromArgb(123, 31, 62);
            btnCategorias.Location = new Point(100, 10);
            btnCategorias.Margin = new Padding(3, 10, 10, 10);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(120, 30);
            btnCategorias.TabIndex = 6;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.FromArgb(253, 245, 245);
            panelToolbar.Controls.Add(lblTitulo);
            panelToolbar.Controls.Add(btnCategorias);
            panelToolbar.Controls.Add(chkFavoritos1);
            panelToolbar.Controls.Add(btnExport);
            panelToolbar.Controls.Add(btnImport);
            panelToolbar.Controls.Add(btnNuevoContacto);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(902, 50);
            panelToolbar.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(123, 31, 62);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(86, 21);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Contactos";
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 610);
            Controls.Add(dgvContactos);
            Controls.Add(panelToolbar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 600);
            Name = "FrmContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefónica";
            Load += FrmContactos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContactos;
        private Button btnNuevoContacto;
        private Button btnImport;
        private Button btnExport;
        private Button btnCategorias;
        private CheckBox chkFavoritos1;
        private Panel panelToolbar;
        private Label lblTitulo;
    }
}