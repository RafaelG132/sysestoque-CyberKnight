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
            txt_qtd = new TextBox();
            textBox3 = new TextBox();
            txt_id = new TextBox();
            textBox5 = new TextBox();
            lbl_id = new Label();
            lbl_categoria = new Label();
            lbl_qtd = new Label();
            lbl_descricao = new Label();
            lbl_precoUnt = new Label();
            txt_categoria = new ComboBox();
            lbl_unidade = new Label();
            comboBox2 = new ComboBox();
            btn_atualizar = new Button();
            btn_incluir = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 22);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Produtos";
            label1.BindingContextChanged += label1_BindingContextChanged;
            // 
            // txt_qtd
            // 
            txt_qtd.Location = new Point(120, 161);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(100, 23);
            txt_qtd.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(438, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(70, 62);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(64, 23);
            txt_id.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(417, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 23);
            textBox5.TabIndex = 5;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.BackColor = Color.Transparent;
            lbl_id.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.ForeColor = SystemColors.ControlLightLight;
            lbl_id.Location = new Point(43, 66);
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
            lbl_categoria.Location = new Point(43, 113);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(61, 15);
            lbl_categoria.TabIndex = 8;
            lbl_categoria.Text = "Categoria:";
            lbl_categoria.Click += lbl_categoria_Click;
            // 
            // lbl_qtd
            // 
            lbl_qtd.AutoSize = true;
            lbl_qtd.BackColor = Color.Transparent;
            lbl_qtd.ForeColor = SystemColors.ControlLightLight;
            lbl_qtd.Location = new Point(43, 164);
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
            lbl_descricao.Location = new Point(350, 110);
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
            lbl_precoUnt.Location = new Point(350, 62);
            lbl_precoUnt.Name = "lbl_precoUnt";
            lbl_precoUnt.Size = new Size(85, 15);
            lbl_precoUnt.TabIndex = 11;
            lbl_precoUnt.Text = "Preço Unitário:";
            // 
            // txt_categoria
            // 
            txt_categoria.FormattingEnabled = true;
            txt_categoria.Location = new Point(110, 110);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(110, 23);
            txt_categoria.TabIndex = 12;
            // 
            // lbl_unidade
            // 
            lbl_unidade.AutoSize = true;
            lbl_unidade.BackColor = Color.Transparent;
            lbl_unidade.ForeColor = SystemColors.ControlLightLight;
            lbl_unidade.Location = new Point(350, 161);
            lbl_unidade.Name = "lbl_unidade";
            lbl_unidade.Size = new Size(54, 15);
            lbl_unidade.TabIndex = 13;
            lbl_unidade.Text = "Unidade:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(410, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(77, 23);
            comboBox2.TabIndex = 14;
            // 
            // btn_atualizar
            // 
            btn_atualizar.BackColor = Color.Transparent;
            btn_atualizar.Location = new Point(241, 415);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(75, 23);
            btn_atualizar.TabIndex = 15;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = Color.Transparent;
            btn_incluir.Location = new Point(322, 415);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(75, 23);
            btn_incluir.TabIndex = 16;
            btn_incluir.Text = "Incluir";
            btn_incluir.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.Transparent;
            btn_excluir.Location = new Point(403, 415);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(75, 23);
            btn_excluir.TabIndex = 17;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.Transparent;
            btn_salvar.Location = new Point(484, 415);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 18;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(510, 166);
            dataGridView1.TabIndex = 19;
            // 
            // Form_CadastroDeProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Apresentação_de_Plano_de_Marketing_Minimalista_Bege_e_Rosa;
            ClientSize = new Size(566, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_salvar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_incluir);
            Controls.Add(btn_atualizar);
            Controls.Add(comboBox2);
            Controls.Add(lbl_unidade);
            Controls.Add(txt_categoria);
            Controls.Add(lbl_precoUnt);
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_qtd);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_id);
            Controls.Add(textBox5);
            Controls.Add(txt_id);
            Controls.Add(textBox3);
            Controls.Add(txt_qtd);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_CadastroDeProduto";
            Text = "Form_CadastroDeProduto";
            Load += Form_CadastroDeProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_qtd;
        private TextBox textBox3;
        private TextBox txt_id;
        private TextBox textBox5;
        private Label lbl_id;
        private Label lbl_categoria;
        private Label lbl_qtd;
        private Label lbl_descricao;
        private Label lbl_precoUnt;
        private ComboBox txt_categoria;
        private Label lbl_unidade;
        private ComboBox comboBox2;
        private Button btn_atualizar;
        private Button btn_incluir;
        private Button btn_excluir;
        private Button btn_salvar;
        private DataGridView dataGridView1;
    }
}