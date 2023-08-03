namespace sysestoque_CyberKnight
{
    partial class FormLogin
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
            btnLogin = new Button();
            txtSenha = new Label();
            txbSenha = new TextBox();
            txbLogin = new TextBox();
            txtLogin = new Label();
            btnVerSenha = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(599, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(568, 197);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(42, 15);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "Senha:";
            txtSenha.Click += txtSenha_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(568, 227);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(145, 23);
            txbSenha.TabIndex = 2;
            txbSenha.UseSystemPasswordChar = true;
            txbSenha.TextChanged += txbSenha_TextChanged;
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(568, 140);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(145, 23);
            txbLogin.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.Location = new Point(568, 113);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(40, 15);
            txtLogin.TabIndex = 1;
            txtLogin.Text = "Login:";
            // 
            // btnVerSenha
            // 
            btnVerSenha.Location = new Point(719, 227);
            btnVerSenha.Name = "btnVerSenha";
            btnVerSenha.Size = new Size(33, 23);
            btnVerSenha.TabIndex = 3;
            btnVerSenha.Text = "👁‍🗨";
            btnVerSenha.UseVisualStyleBackColor = true;
            btnVerSenha.Click += btnVerSenha_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerSenha);
            Controls.Add(txbLogin);
            Controls.Add(txbSenha);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label txtSenha;
        private TextBox txbSenha;
        private TextBox txbLogin;
        private Label txtLogin;
        private Button btnVerSenha;
    }
}