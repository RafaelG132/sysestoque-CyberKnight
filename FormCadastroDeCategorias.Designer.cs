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
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnIncluir = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 113);
            textBox3.MaxLength = 100;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(17, 116);
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
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(66, 67);
            textBox4.MaxLength = 100;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(266, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 28);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(769, 195);
            dataGridView1.TabIndex = 9;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.DodgerBlue;
            btnIncluir.ForeColor = SystemColors.Control;
            btnIncluir.Location = new Point(573, 422);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 11;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.DodgerBlue;
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(654, 422);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DodgerBlue;
            btnSalvar.BackgroundImageLayout = ImageLayout.None;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(735, 422);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DodgerBlue;
            btnAtualizar.ForeColor = SystemColors.Control;
            btnAtualizar.Location = new Point(492, 423);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.UseWaitCursor = true;
            // 
            // FormCadastroDeCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(819, 455);
            Controls.Add(btnAtualizar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(btnIncluir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroDeCategorias";
            Text = "Cadastro de Categorias";
            Load += FormCadastroDeCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnIncluir;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnAtualizar;
    }
}