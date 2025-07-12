
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgendaTelefonica
{
    partial class FrmCategorias
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
            dgvCategorias = new DataGridView();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelFooter = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();

            // 
            // dgvCategorias
            // 
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.BackgroundColor = Color.FromArgb(253, 245, 245);
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.GridColor = Color.FromArgb(230, 230, 230);
            dgvCategorias.Location = new Point(20, 60);
            dgvCategorias.Margin = new Padding(3, 10, 3, 10);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.RowTemplate.Height = 25;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(432, 250);
            dgvCategorias.TabIndex = 0;

            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.BackColor = Color.FromArgb(253, 245, 245);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombre.Location = new Point(20, 15);
            txtNombre.Margin = new Padding(3, 10, 3, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;

            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(123, 31, 62);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(230, 15);
            btnAgregar.Margin = new Padding(3, 10, 10, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 25);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;

            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(253, 245, 245);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(123, 31, 62);
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(123, 31, 62);
            btnEliminar.Location = new Point(340, 15);
            btnEliminar.Margin = new Padding(3, 10, 20, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 25);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;

            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Nueva Categoría:";

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(253, 245, 245);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(472, 50);
            panelHeader.TabIndex = 5;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(123, 31, 62);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Categorías";

            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(253, 245, 245);
            panelFooter.Controls.Add(label1);
            panelFooter.Controls.Add(txtNombre);
            panelFooter.Controls.Add(btnAgregar);
            panelFooter.Controls.Add(btnEliminar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 320);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(472, 50);
            panelFooter.TabIndex = 6;

            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 370);
            Controls.Add(dgvCategorias);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(488, 409);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Categorías";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridView dgvCategorias;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label label1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelFooter;
    }
}