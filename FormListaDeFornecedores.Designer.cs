namespace sysestoque_CyberKnight
{
    partial class FormListaDeFornecedores
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
            label1 = new Label();
            btnFornecedores = new Button();
            dgvFornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista Fornecedores:";
            label1.Click += label1_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.DialogResult = DialogResult.OK;
            btnFornecedores.Location = new Point(650, 415);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Size = new Size(138, 23);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "Selecionar Fornecedor";
            btnFornecedores.UseVisualStyleBackColor = true;
            btnFornecedores.Click += btnFornecedores_Click;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(12, 27);
            dgvFornecedores.MultiSelect = false;
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.RowTemplate.Height = 25;
            dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedores.Size = new Size(776, 321);
            dgvFornecedores.TabIndex = 2;
            dgvFornecedores.CellContentClick += dgvFornecedores_CellContentClick;
            // 
            // FormListaDeFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvFornecedores);
            Controls.Add(btnFornecedores);
            Controls.Add(label1);
            Name = "FormListaDeFornecedores";
            Text = "FormListaDeFornecedores";
            Load += FormListaDeFornecedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFornecedores;
        private DataGridView dgvFornecedores;
    }
}