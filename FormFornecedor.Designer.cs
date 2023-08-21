namespace sysestoque_CyberKnight
{
    partial class FormFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedor));
            btnAtualizar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            txtTelefone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dgvFornecedor = new DataGridView();
            txtNome = new TextBox();
            label1 = new Label();
            txtEndereco = new TextBox();
            txtCNPJ = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtResponsavel = new TextBox();
            label7 = new Label();
            txtRazaoSocial = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.ForeColor = SystemColors.ControlText;
            btnAtualizar.Location = new Point(570, 415);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.UseWaitCursor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BackgroundImageLayout = ImageLayout.None;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.ForeColor = SystemColors.ControlText;
            btnSalvar.Location = new Point(732, 415);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Location = new Point(651, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(330, 40);
            txtTelefone.MaxLength = 100;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(189, 23);
            txtTelefone.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(270, 43);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Telefone:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 88);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 17;
            label4.Text = "Nome:";
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Location = new Point(12, 222);
            dgvFornecedor.MultiSelect = false;
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.RowTemplate.Height = 25;
            dgvFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedor.Size = new Size(795, 166);
            dgvFornecedor.TabIndex = 19;
            dgvFornecedor.CellContentClick += dgvFornecedor_CellContentClick;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 85);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(327, 23);
            txtNome.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 134);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 24;
            label1.Text = "Endereço:";
            label1.Click += label1_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(61, 131);
            txtEndereco.MaxLength = 100;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(327, 23);
            txtEndereco.TabIndex = 25;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(61, 40);
            txtCNPJ.MaxLength = 100;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(189, 23);
            txtCNPJ.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 26;
            label2.Text = "CNPJ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 177);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 28;
            label5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(61, 174);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 23);
            txtEmail.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(395, 180);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 32;
            label6.Text = "Responsável:";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(476, 177);
            txtResponsavel.MaxLength = 100;
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(323, 23);
            txtResponsavel.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(395, 137);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 30;
            label7.Text = "Razão Social:";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(476, 134);
            txtRazaoSocial.MaxLength = 100;
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(323, 23);
            txtRazaoSocial.TabIndex = 31;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(817, 450);
            Controls.Add(label6);
            Controls.Add(txtResponsavel);
            Controls.Add(label7);
            Controls.Add(txtRazaoSocial);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtCNPJ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(btnAtualizar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dgvFornecedor);
            Controls.Add(txtNome);
            Name = "FormFornecedor";
            Text = "Fornecedores";
            Load += FormFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtualizar;
        private Button btnSalvar;
        private Button btnExcluir;
        private TextBox txtTelefone;
        private Label label3;
        private Label label4;
        private DataGridView dgvFornecedor;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtEndereco;
        private TextBox txtCNPJ;
        private Label label2;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtResponsavel;
        private Label label7;
        private TextBox txtRazaoSocial;
    }
}