namespace sysestoque_CyberKnight
{
    partial class FormNotaEntrada
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            button2 = new Button();
            txbCnpj = new TextBox();
            label4 = new Label();
            txbEmail = new TextBox();
            label7 = new Label();
            txbTelefone = new TextBox();
            label6 = new Label();
            txbEndereço = new TextBox();
            label5 = new Label();
            txbNome = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            DgvNotaEntrada = new DataGridView();
            button3 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvNotaEntrada).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txbCnpj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txbEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txbTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txbEndereço);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txbNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 174);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fornecedor: ";
            // 
            // button2
            // 
            button2.Location = new Point(711, 145);
            button2.Name = "button2";
            button2.Size = new Size(141, 23);
            button2.TabIndex = 4;
            button2.Text = "Selecionar Fornecedor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txbCnpj
            // 
            txbCnpj.Location = new Point(328, 31);
            txbCnpj.Name = "txbCnpj";
            txbCnpj.Size = new Size(141, 23);
            txbCnpj.TabIndex = 3;
            txbCnpj.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 34);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 2;
            label4.Text = "Cnpj:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(559, 31);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(180, 23);
            txbEmail.TabIndex = 3;
            txbEmail.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 34);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 2;
            label7.Text = "Email:";
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(349, 98);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(180, 23);
            txbTelefone.TabIndex = 3;
            txbTelefone.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 101);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 2;
            label6.Text = "Telefone:";
            // 
            // txbEndereço
            // 
            txbEndereço.Location = new Point(63, 98);
            txbEndereço.Name = "txbEndereço";
            txbEndereço.Size = new Size(194, 23);
            txbEndereço.TabIndex = 3;
            txbEndereço.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 101);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Endereço:";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(63, 36);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(194, 23);
            txbNome.TabIndex = 3;
            txbNome.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 39);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Numeração:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor Total:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(DgvNotaEntrada);
            groupBox2.Location = new Point(12, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 216);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos: ";
            // 
            // button1
            // 
            button1.Location = new Point(711, 22);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 1;
            button1.Text = "Add.Produto";
            button1.UseVisualStyleBackColor = true;
            // 
            // DgvNotaEntrada
            // 
            DgvNotaEntrada.BackgroundColor = SystemColors.Control;
            DgvNotaEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNotaEntrada.Location = new Point(6, 55);
            DgvNotaEntrada.Name = "DgvNotaEntrada";
            DgvNotaEntrada.RowTemplate.Height = 25;
            DgvNotaEntrada.Size = new Size(846, 150);
            DgvNotaEntrada.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(729, 563);
            button3.Name = "button3";
            button3.Size = new Size(141, 23);
            button3.TabIndex = 1;
            button3.Text = "Inserir Nota";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(342, 49);
            label8.Name = "label8";
            label8.Size = new Size(29, 21);
            label8.TabIndex = 2;
            label8.Text = "R$";
            // 
            // FormNotaEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 598);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormNotaEntrada";
            Text = "FormNotaEntrada";
            Load += FormNotaEntrada_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvNotaEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridView DgvNotaEntrada;
        private TextBox txbCnpj;
        private Label label4;
        private TextBox txbNome;
        private Label label3;
        private TextBox txbEndereço;
        private Label label5;
        private TextBox txbTelefone;
        private Label label6;
        private TextBox txbEmail;
        private Label label7;
        private Button button2;
        private Button button3;
        private Label label8;
    }
}