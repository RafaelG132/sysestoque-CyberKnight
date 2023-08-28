namespace sysestoque_CyberKnight {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarNovoProdutoToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            notaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
            notaDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            informaçõesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusLabelMsgPrincipal = new ToolStripStatusLabel();
            dgvProdutoTelaPrincipal = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            UnidadeMedida = new DataGridViewTextBoxColumn();
            ItensEntrada = new DataGridViewTextBoxColumn();
            ItensSaida = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtEstoqueMinimo = new TextBox();
            txtEstoqueMaximo = new TextBox();
            label2 = new Label();
            txtEstoqueMedio = new TextBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutoTelaPrincipal).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, fornecedorToolStripMenuItem, notaDeEntradaToolStripMenuItem, notaDeSaídaToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoProdutoToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarNovoProdutoToolStripMenuItem
            // 
            cadastrarNovoProdutoToolStripMenuItem.Name = "cadastrarNovoProdutoToolStripMenuItem";
            cadastrarNovoProdutoToolStripMenuItem.Size = new Size(200, 22);
            cadastrarNovoProdutoToolStripMenuItem.Text = "Cadastrar novo produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(79, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // notaDeEntradaToolStripMenuItem
            // 
            notaDeEntradaToolStripMenuItem.Name = "notaDeEntradaToolStripMenuItem";
            notaDeEntradaToolStripMenuItem.Size = new Size(104, 20);
            notaDeEntradaToolStripMenuItem.Text = "Nota de Entrada";
            // 
            // notaDeSaídaToolStripMenuItem
            // 
            notaDeSaídaToolStripMenuItem.Name = "notaDeSaídaToolStripMenuItem";
            notaDeSaídaToolStripMenuItem.Size = new Size(92, 20);
            notaDeSaídaToolStripMenuItem.Text = "Nota de Saída";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaçõesToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // informaçõesToolStripMenuItem
            // 
            informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            informaçõesToolStripMenuItem.Size = new Size(140, 22);
            informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusLabelMsgPrincipal });
            statusStrip1.Location = new Point(0, 350);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(66, 17);
            toolStripStatusLabel1.Text = "Mensagem";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // statusLabelMsgPrincipal
            // 
            statusLabelMsgPrincipal.AutoSize = false;
            statusLabelMsgPrincipal.Name = "statusLabelMsgPrincipal";
            statusLabelMsgPrincipal.Size = new Size(300, 17);
            // 
            // dgvProdutoTelaPrincipal
            // 
            dgvProdutoTelaPrincipal.AllowUserToAddRows = false;
            dgvProdutoTelaPrincipal.AllowUserToDeleteRows = false;
            dgvProdutoTelaPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProdutoTelaPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutoTelaPrincipal.BackgroundColor = SystemColors.Control;
            dgvProdutoTelaPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutoTelaPrincipal.Columns.AddRange(new DataGridViewColumn[] { Id, nome, descricao, Categoria, UnidadeMedida, ItensEntrada, ItensSaida });
            dgvProdutoTelaPrincipal.Location = new Point(12, 39);
            dgvProdutoTelaPrincipal.MultiSelect = false;
            dgvProdutoTelaPrincipal.Name = "dgvProdutoTelaPrincipal";
            dgvProdutoTelaPrincipal.ReadOnly = true;
            dgvProdutoTelaPrincipal.RowTemplate.Height = 25;
            dgvProdutoTelaPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutoTelaPrincipal.Size = new Size(776, 205);
            dgvProdutoTelaPrincipal.TabIndex = 2;
            dgvProdutoTelaPrincipal.CellContentClick += dgvProdutoTelaPrincipal_CellContentClick;
            dgvProdutoTelaPrincipal.CellFormatting += dgvProdutoTelaPrincipal_CellFormatting;
            dgvProdutoTelaPrincipal.SelectionChanged += dgvProdutoTelaPrincipal_SelectionChanged;
            dgvProdutoTelaPrincipal.Click += dgvProdutoTelaPrincipal_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.DataPropertyName = "descricao";
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria.Nome";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // UnidadeMedida
            // 
            UnidadeMedida.DataPropertyName = "UnidadeMedida.Nome";
            UnidadeMedida.HeaderText = "Unidade de Medida";
            UnidadeMedida.Name = "UnidadeMedida";
            UnidadeMedida.ReadOnly = true;
            // 
            // ItensEntrada
            // 
            ItensEntrada.DataPropertyName = "ItensEntrada";
            ItensEntrada.HeaderText = "Item Entrada";
            ItensEntrada.Name = "ItensEntrada";
            ItensEntrada.ReadOnly = true;
            // 
            // ItensSaida
            // 
            ItensSaida.DataPropertyName = "ItensSaida";
            ItensSaida.HeaderText = "Item Saída";
            ItensSaida.Name = "ItensSaida";
            ItensSaida.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 258);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Estoque mínimo:";
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtEstoqueMinimo.Enabled = false;
            txtEstoqueMinimo.Location = new Point(115, 255);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(192, 23);
            txtEstoqueMinimo.TabIndex = 4;
            txtEstoqueMinimo.TextChanged += textBox1_TextChanged;
            // 
            // txtEstoqueMaximo
            // 
            txtEstoqueMaximo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtEstoqueMaximo.Enabled = false;
            txtEstoqueMaximo.Location = new Point(115, 307);
            txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            txtEstoqueMaximo.Size = new Size(192, 23);
            txtEstoqueMaximo.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 310);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Estoque máximo:";
            // 
            // txtEstoqueMedio
            // 
            txtEstoqueMedio.Enabled = false;
            txtEstoqueMedio.Location = new Point(431, 255);
            txtEstoqueMedio.Name = "txtEstoqueMedio";
            txtEstoqueMedio.Size = new Size(192, 23);
            txtEstoqueMedio.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(328, 258);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Estoque médio:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(txtEstoqueMedio);
            Controls.Add(label3);
            Controls.Add(txtEstoqueMaximo);
            Controls.Add(label2);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(label1);
            Controls.Add(dgvProdutoTelaPrincipal);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutoTelaPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem notaDeEntradaToolStripMenuItem;
        private ToolStripMenuItem notaDeSaídaToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem informaçõesToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusLabelMsgPrincipal;
        private ToolStripMenuItem cadastrarNovoProdutoToolStripMenuItem;
        private DataGridView dgvProdutoTelaPrincipal;
        private Label label1;
        private TextBox txtEstoqueMinimo;
        private TextBox txtEstoqueMaximo;
        private Label label2;
        private TextBox txtEstoqueMedio;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn UnidadeMedida;
        private DataGridViewTextBoxColumn ItensEntrada;
        private DataGridViewTextBoxColumn ItensSaida;
    }
}