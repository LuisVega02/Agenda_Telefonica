namespace AgendaTelefonica
{
    partial class FrmLogin
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            panelMain = new Panel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();

            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(253, 245, 245);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(20, 50);
            txtUsuario.Margin = new Padding(3, 10, 3, 10);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 23);
            txtUsuario.TabIndex = 0;

            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(253, 245, 245);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            txtContraseña.Location = new Point(20, 100);
            txtContraseña.Margin = new Padding(3, 10, 3, 10);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(260, 23);
            txtContraseña.TabIndex = 1;

            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(123, 31, 62);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 150);
            btnLogin.Margin = new Padding(3, 10, 3, 10);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(260, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";

            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtUsuario);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(txtContraseña);
            panelMain.Controls.Add(btnLogin);
            panelMain.Location = new Point(0, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(300, 200);
            panelMain.TabIndex = 5;

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(123, 31, 62);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(300, 50);
            panelHeader.TabIndex = 6;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar Sesión";

            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 250);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Panel panelMain;
        private Panel panelHeader;
        private Label lblTitulo;
    }
}