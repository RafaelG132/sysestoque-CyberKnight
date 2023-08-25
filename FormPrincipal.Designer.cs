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
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusLabelMsgPrincipal = new ToolStripStatusLabel();
            notaDeEntradaToolStripMenuItem = new ToolStripMenuItem();
            notaDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            informaçõesToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            cadastrarNovoProdutoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, statusLabelMsgPrincipal });
            statusStrip1.Location = new Point(0, 350);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarNovoProdutoToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(79, 20);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
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
            informaçõesToolStripMenuItem.Size = new Size(180, 22);
            informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 205);
            dataGridView1.TabIndex = 2;
            // 
            // cadastrarNovoProdutoToolStripMenuItem
            // 
            cadastrarNovoProdutoToolStripMenuItem.Name = "cadastrarNovoProdutoToolStripMenuItem";
            cadastrarNovoProdutoToolStripMenuItem.Size = new Size(200, 22);
            cadastrarNovoProdutoToolStripMenuItem.Text = "Cadastrar novo produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 258);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Estoque mínimo:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(115, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(115, 307);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 310);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Estoque máximo:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(431, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
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
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}