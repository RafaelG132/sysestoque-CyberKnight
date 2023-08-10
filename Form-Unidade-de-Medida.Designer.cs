namespace sysestoque_CyberKnight
{
    partial class Form_Unidade_de_Medida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Unidade_de_Medida));
            groupBox1 = new GroupBox();
            label1 = new Label();
            txbSigla = new TextBox();
            dgvUnidade_medida = new DataGridView();
            id_unidade = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            lbl_nome = new Label();
            txtId = new TextBox();
            btn_atualizar = new Button();
            btn_excluir = new Button();
            btn_incluir = new Button();
            lbl_idunidade = new Label();
            txtNome = new TextBox();
            btn_salvar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidade_medida).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txbSigla);
            groupBox1.Controls.Add(dgvUnidade_medida);
            groupBox1.Controls.Add(lbl_nome);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btn_atualizar);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_incluir);
            groupBox1.Controls.Add(lbl_idunidade);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(btn_salvar);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unidade De Medida";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(213, 76);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 10;
            label1.Text = "Sigla:";
            label1.Click += label1_Click;
            // 
            // txbSigla
            // 
            txbSigla.Location = new Point(264, 73);
            txbSigla.Name = "txbSigla";
            txbSigla.Size = new Size(100, 23);
            txbSigla.TabIndex = 9;
            txbSigla.TextChanged += textBox1_TextChanged;
            // 
            // dgvUnidade_medida
            // 
            dgvUnidade_medida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnidade_medida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnidade_medida.Columns.AddRange(new DataGridViewColumn[] { id_unidade, nome });
            dgvUnidade_medida.Location = new Point(11, 179);
            dgvUnidade_medida.Name = "dgvUnidade_medida";
            dgvUnidade_medida.RowTemplate.Height = 25;
            dgvUnidade_medida.Size = new Size(515, 150);
            dgvUnidade_medida.TabIndex = 8;
            // 
            // id_unidade
            // 
            id_unidade.DataPropertyName = "Id";
            id_unidade.HeaderText = "id_unidade";
            id_unidade.Name = "id_unidade";
            // 
            // nome
            // 
            nome.DataPropertyName = "NomeExtenso";
            nome.HeaderText = "nome";
            nome.Name = "nome";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.ForeColor = SystemColors.ControlLightLight;
            lbl_nome.Location = new Point(11, 129);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(45, 15);
            lbl_nome.TabIndex = 7;
            lbl_nome.Text = "NOME:";
            lbl_nome.Click += label2_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(451, 356);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(75, 23);
            btn_atualizar.TabIndex = 5;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(370, 356);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 23);
            btn_excluir.TabIndex = 4;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_incluir
            // 
            btn_incluir.Location = new Point(289, 356);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(75, 23);
            btn_incluir.TabIndex = 3;
            btn_incluir.Text = "Incluir";
            btn_incluir.UseVisualStyleBackColor = true;
            // 
            // lbl_idunidade
            // 
            lbl_idunidade.AutoSize = true;
            lbl_idunidade.ForeColor = SystemColors.ControlLightLight;
            lbl_idunidade.Location = new Point(11, 76);
            lbl_idunidade.Name = "lbl_idunidade";
            lbl_idunidade.Size = new Size(74, 15);
            lbl_idunidade.TabIndex = 2;
            lbl_idunidade.Text = "ID UNIDADE:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 126);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // btn_salvar
            // 
            btn_salvar.ForeColor = SystemColors.ControlText;
            btn_salvar.Location = new Point(208, 356);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_Salvar_Click;
            // 
            // Form_Unidade_de_Medida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Apresentação_de_Plano_de_Marketing_Minimalista_Bege_e_Rosa;
            ClientSize = new Size(539, 414);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Unidade_de_Medida";
            Text = "Unidade De Medida";
            Load += Form_Unidade_de_Medida_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidade_medida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_nome;
        private TextBox txtId;
        private Button btn_atualizar;
        private Button btn_excluir;
        private Button btn_incluir;
        private Label lbl_idunidade;
        private TextBox txtNome;
        private Button btn_salvar;
        private DataGridView dgvUnidade_medida;
        private DataGridViewTextBoxColumn id_unidade;
        private DataGridViewTextBoxColumn nome;
        private Label label1;
        private TextBox txbSigla;
    }
}