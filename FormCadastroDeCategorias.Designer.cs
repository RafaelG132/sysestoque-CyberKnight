namespace sysestoque_CyberKnight
{
    partial class FormCadastroDeCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeCategorias));
            txtDescricao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtId = new TextBox();
            dgvCategoria = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnAtualizar = new Button();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 111);
            txtDescricao.MaxLength = 100;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(381, 23);
            txtDescricao.TabIndex = 5;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(51, 28);
            txtId.MaxLength = 100;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(95, 23);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoria.BackgroundColor = SystemColors.Control;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Descricao });
            dgvCategoria.Location = new Point(24, 198);
            dgvCategoria.MultiSelect = false;
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowTemplate.Height = 25;
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(769, 195);
            dgvCategoria.TabIndex = 9;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Location = new Point(637, 422);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BackgroundImageLayout = ImageLayout.None;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.ForeColor = SystemColors.ControlText;
            btnSalvar.Location = new Point(718, 169);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAtualizar.BackColor = Color.Transparent;
            btnAtualizar.ForeColor = SystemColors.ControlText;
            btnAtualizar.Location = new Point(718, 422);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 67);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(381, 23);
            txtNome.TabIndex = 16;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // FormCadastroDeCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(819, 455);
            Controls.Add(txtNome);
            Controls.Add(btnAtualizar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dgvCategoria);
            Controls.Add(label1);
            Controls.Add(txtId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroDeCategorias";
            Text = "Cadastro de Categorias";
            Load += FormCadastroDeCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtId;
        private DataGridView dgvCategoria;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private TextBox txtNome;
        private ToolStripStatusLabel msgBarraStatus;
    }
}