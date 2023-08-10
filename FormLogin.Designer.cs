namespace sysestoque_CyberKnight
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            label1 = new Label();
            txbSenha = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            pb_CyberKnights = new PictureBox();
            label8 = new Label();
            pb_olho = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_CyberKnights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_olho).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(191, 240);
            label1.Name = "label1";
            label1.Size = new Size(37, 14);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(190, 315);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(413, 23);
            txbSenha.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(190, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 25);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(191, 294);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(191, 347);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 6;
            label3.Text = "Esqueceu a Senha?";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Highlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Highlight;
            textBox3.Location = new Point(190, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(412, 22);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(2, 543);
            label5.Name = "label5";
            label5.Size = new Size(363, 15);
            label5.TabIndex = 9;
            label5.Text = "Todos os direitos resevados aos criadores do Cyber Knights";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(190, 202);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 10;
            label6.Text = "Acessar Conta";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuHighlight;
            label4.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(361, 388);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 11;
            label4.Text = "Entrar";
            label4.Click += label4_Click;
            // 
            // pb_CyberKnights
            // 
            pb_CyberKnights.Image = (Image)resources.GetObject("pb_CyberKnights.Image");
            pb_CyberKnights.Location = new Point(176, 82);
            pb_CyberKnights.Name = "pb_CyberKnights";
            pb_CyberKnights.Size = new Size(444, 117);
            pb_CyberKnights.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_CyberKnights.TabIndex = 12;
            pb_CyberKnights.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(697, 543);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 14;
            label8.Text = "Cyber Knights 2023";
            // 
            // pb_olho
            // 
            pb_olho.Cursor = Cursors.Hand;
            pb_olho.Image = (Image)resources.GetObject("pb_olho.Image");
            pb_olho.Location = new Point(609, 315);
            pb_olho.Name = "pb_olho";
            pb_olho.Size = new Size(29, 23);
            pb_olho.SizeMode = PictureBoxSizeMode.Zoom;
            pb_olho.TabIndex = 15;
            pb_olho.TabStop = false;
            pb_olho.Click += pictureBox2_Click;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(829, 567);
            Controls.Add(pb_olho);
            Controls.Add(label8);
            Controls.Add(pb_CyberKnights);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txbSenha);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Login";
            Text = "Tela de Login";
            Load += Form_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pb_CyberKnights).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_olho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txbSenha;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label4;
        private PictureBox pb_CyberKnights;
        private Label label8;
        private PictureBox pb_olho;
    }
}