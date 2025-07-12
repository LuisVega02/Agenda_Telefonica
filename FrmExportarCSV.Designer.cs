namespace AgendaTelefonica
{
    partial class FrmExportarCSV
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
            dgvExport = new DataGridView();
            btnExportar = new Button();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFooter = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvExport).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvExport
            // 
            dgvExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExport.BackgroundColor = Color.FromArgb(253, 245, 245);
            dgvExport.BorderStyle = BorderStyle.None;
            dgvExport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExport.GridColor = Color.FromArgb(230, 230, 230);
            dgvExport.Location = new Point(20, 60);
            dgvExport.Margin = new Padding(3, 10, 3, 10);
            dgvExport.Name = "dgvExport";
            dgvExport.RowHeadersVisible = false;
            dgvExport.RowHeadersWidth = 51;
            dgvExport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExport.Size = new Size(760, 300);
            dgvExport.TabIndex = 0;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom;
            btnExportar.BackColor = Color.FromArgb(123, 31, 62);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(340, 15);
            btnExportar.Margin = new Padding(3, 10, 3, 10);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 35);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click_1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(253, 245, 245);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 50);
            panelHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(123, 31, 62);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Exportar Contactos a CSV";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(253, 245, 245);
            panelFooter.Controls.Add(btnExportar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 380);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 70);
            panelFooter.TabIndex = 3;
            // 
            // FrmExportarCSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvExport);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(816, 489);
            Name = "FrmExportarCSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportar a CSV";
            Load += FrmExportarCSV_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvExport).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dgvExport;
        private Button btnExportar;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelFooter;
    }
}