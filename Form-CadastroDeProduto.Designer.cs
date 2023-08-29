namespace sysestoque_CyberKnight
{
    partial class Form_CadastroDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroDeProduto));
            label1 = new Label();
            txtqtd = new TextBox();
            txtprecoUnit = new TextBox();
            txt_id = new TextBox();
            txtdescricao = new TextBox();
            lbl_id = new Label();
            lbl_categoria = new Label();
            lbl_qtd = new Label();
            lbl_descricao = new Label();
            lbl_precoUnt = new Label();
            cbxProdCategoria = new ComboBox();
            lbl_unidade = new Label();
            cbxProdUnidMedida = new ComboBox();
            btn_atualizar = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            dgv_Produto = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Qtd_Estoque = new DataGridViewTextBoxColumn();
            Preço_Unitario = new DataGridViewTextBoxColumn();
            estoquemax = new DataGridViewTextBoxColumn();
            estoquemedio = new DataGridViewTextBoxColumn();
            UnidadeMedida = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            txtestoquemedio = new TextBox();
            txtestoquemax = new TextBox();
            menuStrip1 = new MenuStrip();
            txtnome = new TextBox();
            lbl_nome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Produto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(196, 22);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Produtos";
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(384, 67);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(100, 23);
            txtqtd.TabIndex = 2;
            // 
            // txtprecoUnit
            // 
            txtprecoUnit.Location = new Point(591, 66);
            txtprecoUnit.Name = "txtprecoUnit";
            txtprecoUnit.Size = new Size(100, 23);
            txtprecoUnit.TabIndex = 3;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(64, 66);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(40, 23);
            txt_id.TabIndex = 4;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(110, 115);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(121, 23);
            txtdescricao.TabIndex = 5;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.ForeColor = SystemColors.ControlLightLight;
            lbl_id.Location = new Point(43, 70);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(21, 13);
            lbl_id.TabIndex = 7;
            lbl_id.Text = "ID:";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.BackColor = Color.Transparent;
            lbl_categoria.ForeColor = SystemColors.ControlLightLight;
            lbl_categoria.Location = new Point(120, 70);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(61, 15);
            lbl_categoria.TabIndex = 8;
            lbl_categoria.Text = "Categoria:";
            // 
            // lbl_qtd
            // 
            lbl_qtd.AutoSize = true;
            lbl_qtd.BackColor = Color.Transparent;
            lbl_qtd.ForeColor = SystemColors.ControlLightLight;
            lbl_qtd.Location = new Point(303, 70);
            lbl_qtd.Name = "lbl_qtd";
            lbl_qtd.Size = new Size(75, 15);
            lbl_qtd.TabIndex = 9;
            lbl_qtd.Text = "Qtd Estoque:";
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.BackColor = Color.Transparent;
            lbl_descricao.ForeColor = SystemColors.ControlLightLight;
            lbl_descricao.Location = new Point(43, 118);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(61, 15);
            lbl_descricao.TabIndex = 10;
            lbl_descricao.Text = "Descrição:";
            // 
            // lbl_precoUnt
            // 
            lbl_precoUnt.AutoSize = true;
            lbl_precoUnt.BackColor = Color.Transparent;
            lbl_precoUnt.ForeColor = SystemColors.ControlLightLight;
            lbl_precoUnt.Location = new Point(500, 70);
            lbl_precoUnt.Name = "lbl_precoUnt";
            lbl_precoUnt.Size = new Size(85, 15);
            lbl_precoUnt.TabIndex = 11;
            lbl_precoUnt.Text = "Preço Unitário:";
            // 
            // cbxProdCategoria
            // 
            cbxProdCategoria.FormattingEnabled = true;
            cbxProdCategoria.Location = new Point(187, 67);
            cbxProdCategoria.Name = "cbxProdCategoria";
            cbxProdCategoria.Size = new Size(110, 23);
            cbxProdCategoria.TabIndex = 12;
            // 
            // lbl_unidade
            // 
            lbl_unidade.AutoSize = true;
            lbl_unidade.BackColor = Color.Transparent;
            lbl_unidade.ForeColor = SystemColors.ControlLightLight;
            lbl_unidade.Location = new Point(253, 118);
            lbl_unidade.Name = "lbl_unidade";
            lbl_unidade.Size = new Size(54, 15);
            lbl_unidade.TabIndex = 13;
            lbl_unidade.Text = "Unidade:";
            // 
            // cbxProdUnidMedida
            // 
            cbxProdUnidMedida.FormattingEnabled = true;
            cbxProdUnidMedida.Location = new Point(313, 115);
            cbxProdUnidMedida.Name = "cbxProdUnidMedida";
            cbxProdUnidMedida.Size = new Size(56, 23);
            cbxProdUnidMedida.TabIndex = 14;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_atualizar.BackColor = Color.Transparent;
            btn_atualizar.Location = new Point(535, 427);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(75, 23);
            btn_atualizar.TabIndex = 15;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_excluir.BackColor = Color.Transparent;
            btn_excluir.Location = new Point(616, 427);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 23);
            btn_excluir.TabIndex = 17;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salvar.BackColor = Color.Transparent;
            btn_salvar.Location = new Point(614, 226);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 18;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // dgv_Produto
            // 
            dgv_Produto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Produto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Produto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Produto.Columns.AddRange(new DataGridViewColumn[] { ID, Descrição, IdCategoria, Categoria, Qtd_Estoque, Preço_Unitario, estoquemax, estoquemedio, UnidadeMedida });
            dgv_Produto.Location = new Point(20, 255);
            dgv_Produto.Name = "dgv_Produto";
            dgv_Produto.RowTemplate.Height = 25;
            dgv_Produto.Size = new Size(661, 166);
            dgv_Produto.TabIndex = 19;
            dgv_Produto.CellContentClick += dgv_Produto_CellContentClick;
            dgv_Produto.CellFormatting += dgv_Produto_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "Id";
            ID.Name = "ID";
            // 
            // Descrição
            // 
            Descrição.DataPropertyName = "descricao";
            Descrição.HeaderText = "Descrição";
            Descrição.Name = "Descrição";
            // 
            // IdCategoria
            // 
            IdCategoria.DataPropertyName = "CategoriaId";
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Qtd_Estoque
            // 
            Qtd_Estoque.DataPropertyName = "estoque";
            Qtd_Estoque.HeaderText = "Qtd_Estoque";
            Qtd_Estoque.Name = "Qtd_Estoque";
            // 
            // Preço_Unitario
            // 
            Preço_Unitario.DataPropertyName = "precoUnit";
            Preço_Unitario.HeaderText = "Preço_unitário";
            Preço_Unitario.Name = "Preço_Unitario";
            // 
            // estoquemax
            // 
            estoquemax.DataPropertyName = "estoquemax";
            estoquemax.HeaderText = "estoquemax";
            estoquemax.Name = "estoquemax";
            // 
            // estoquemedio
            // 
            estoquemedio.DataPropertyName = "estoquemedio";
            estoquemedio.HeaderText = "estoquemedio";
            estoquemedio.Name = "estoquemedio";
            // 
            // UnidadeMedida
            // 
            UnidadeMedida.DataPropertyName = "unidadeMedida";
            UnidadeMedida.HeaderText = "UndMed";
            UnidadeMedida.Name = "UnidadeMedida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(43, 166);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 21;
            label3.Text = "estoquemedio:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(388, 118);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 22;
            label4.Text = "estoquemax :";
            // 
            // txtestoquemedio
            // 
            txtestoquemedio.Location = new Point(131, 163);
            txtestoquemedio.Name = "txtestoquemedio";
            txtestoquemedio.Size = new Size(100, 23);
            txtestoquemedio.TabIndex = 23;
            // 
            // txtestoquemax
            // 
            txtestoquemax.Location = new Point(472, 115);
            txtestoquemax.Name = "txtestoquemax";
            txtestoquemax.Size = new Size(100, 23);
            txtestoquemax.TabIndex = 25;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(701, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(302, 166);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 27;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.ForeColor = SystemColors.ControlLightLight;
            lbl_nome.Location = new Point(253, 169);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 30;
            lbl_nome.Text = "Nome:";
            lbl_nome.Click += label5_Click;
            // 
            // Form_CadastroDeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Apresentação_de_Plano_de_Marketing_Minimalista_Bege_e_Rosa;
            ClientSize = new Size(701, 463);
            Controls.Add(lbl_nome);
            Controls.Add(txtnome);
            Controls.Add(txtestoquemax);
            Controls.Add(txtestoquemedio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgv_Produto);
            Controls.Add(btn_salvar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_atualizar);
            Controls.Add(cbxProdUnidMedida);
            Controls.Add(lbl_unidade);
            Controls.Add(cbxProdCategoria);
            Controls.Add(lbl_precoUnt);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_qtd);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_id);
            Controls.Add(txtdescricao);
            Controls.Add(txt_id);
            Controls.Add(txtprecoUnit);
            Controls.Add(txtqtd);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form_CadastroDeProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Produtos";
            WindowState = FormWindowState.Maximized;
            Load += Form_CadastroDeProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Produto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtqtd;
        private TextBox txtprecoUnit;
        private TextBox txt_id;
        private TextBox txtdescricao;
        private Label lbl_id;
        private Label lbl_categoria;
        private Label lbl_qtd;
        private Label lbl_descricao;
        private Label lbl_precoUnt;
        private ComboBox cbxProdCategoria;
        private Label lbl_unidade;
        private ComboBox cbxProdUnidMedida;
        private Button btn_atualizar;
        private Button btn_excluir;
        private Button btn_salvar;
        private DataGridView dataGridView1;
        private DataGridView dgv_Produto;
        private Label label3;
        private Label label4;
        private TextBox txtestoquemedio;
        private TextBox txtestoquemax;
        private MenuStrip menuStrip1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Qtd_Estoque;
        private DataGridViewTextBoxColumn Preço_Unitario;
        private DataGridViewTextBoxColumn estoquemax;
        private DataGridViewTextBoxColumn estoquemedio;
        private DataGridViewTextBoxColumn UnidadeMedida;
        private TextBox txtnome;
        private Label lbl_nome;
    }
}