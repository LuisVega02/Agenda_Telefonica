namespace AgendaTelefonica
{
    partial class FrmImportarCSV
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

        private void InitializeComponent()
        {
            dgvPreview = new DataGridView();
            btnSeleccionarArchivo = new Button();
            btnGuardar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFooter = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();

            // 
            // dgvPreview
            // 
            dgvPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPreview.BackgroundColor = Color.FromArgb(253, 245, 245);
            dgvPreview.BorderStyle = BorderStyle.None;
            dgvPreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.GridColor = Color.FromArgb(230, 230, 230);
            dgvPreview.Location = new Point(20, 60);
            dgvPreview.Margin = new Padding(3, 10, 3, 10);
            dgvPreview.Name = "dgvPreview";
            dgvPreview.RowHeadersVisible = false;
            dgvPreview.RowHeadersWidth = 51;
            dgvPreview.RowTemplate.Height = 25;
            dgvPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPreview.Size = new Size(760, 300);
            dgvPreview.TabIndex = 0;

            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.Anchor = AnchorStyles.Bottom;
            btnSeleccionarArchivo.BackColor = Color.FromArgb(253, 245, 245);
            btnSeleccionarArchivo.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnSeleccionarArchivo.FlatAppearance.BorderSize = 1;
            btnSeleccionarArchivo.FlatStyle = FlatStyle.Flat;
            btnSeleccionarArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionarArchivo.ForeColor = Color.FromArgb(123, 31, 62);
            btnSeleccionarArchivo.Location = new Point(260, 15);
            btnSeleccionarArchivo.Margin = new Padding(3, 10, 10, 10);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(150, 35);
            btnSeleccionarArchivo.TabIndex = 1;
            btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;

            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = Color.FromArgb(123, 31, 62);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(430, 15);
            btnGuardar.Margin = new Padding(3, 10, 20, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Importar Contactos";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(253, 245, 245);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 50);
            panelHeader.TabIndex = 3;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(123, 31, 62);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Importar Contactos CSV";

            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(253, 245, 245);
            panelFooter.Controls.Add(btnSeleccionarArchivo);
            panelFooter.Controls.Add(btnGuardar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 380);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 70);
            panelFooter.TabIndex = 4;

            // 
            // FrmImportarCSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPreview);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(816, 489);
            Name = "FrmImportarCSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importar desde CSV";
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dgvPreview;
        private Button btnSeleccionarArchivo;
        private Button btnGuardar;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelFooter;
    }
}