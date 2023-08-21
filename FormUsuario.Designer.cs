namespace sysestoque_CyberKnight
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            dgvUsuario = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txbLogin = new TextBox();
            textBox2 = new TextBox();
            txbNome = new TextBox();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnSalvar = new Button();
            label3 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            txbSenha = new TextBox();
            txbTelefone = new TextBox();
            txbCpf = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            msgBarraStatus = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(12, 187);
            dgvUsuario.MultiSelect = false;
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(776, 206);
            dgvUsuario.TabIndex = 0;
            dgvUsuario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(8, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(15, 102);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Cpf:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(8, 15);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 2;
            label4.Text = "Login:";
            // 
            // txbLogin
            // 
            txbLogin.Location = new Point(52, 12);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(175, 23);
            txbLogin.TabIndex = 3;
            txbLogin.TextChanged += txbLogin_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(52, 56);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(204, 23);
            txbNome.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(12, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(110, 415);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(713, 158);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(262, 59);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(244, 15);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 2;
            label5.Text = "Senha:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(288, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(288, 12);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(167, 23);
            txbSenha.TabIndex = 3;
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(322, 56);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(124, 23);
            txbTelefone.TabIndex = 3;
            // 
            // txbCpf
            // 
            txbCpf.Location = new Point(52, 99);
            txbCpf.Name = "txbCpf";
            txbCpf.Size = new Size(100, 23);
            txbCpf.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, msgBarraStatus });
            statusStrip1.Location = new Point(0, 465);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(853, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(69, 17);
            toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // msgBarraStatus
            // 
            msgBarraStatus.AutoSize = false;
            msgBarraStatus.Name = "msgBarraStatus";
            msgBarraStatus.Size = new Size(400, 17);
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(853, 487);
            Controls.Add(statusStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(txbCpf);
            Controls.Add(textBox2);
            Controls.Add(txbTelefone);
            Controls.Add(txbSenha);
            Controls.Add(textBox4);
            Controls.Add(txbNome);
            Controls.Add(txbLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuario);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuario;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txbLogin;
        private TextBox textBox2;
        private TextBox txbNome;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnSalvar;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private TextBox txbSenha;
        private TextBox txbTelefone;
        private TextBox txbCpf;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel msgBarraStatus;
    }
}