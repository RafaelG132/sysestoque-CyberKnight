using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using sysestoque_CyberKnight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight
{
    public partial class Form_Login : Form
    {
        Usuario usuario = null;


        public Form_Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txbSenha.UseSystemPasswordChar)
                {
                    txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;
                    pb_olho.Image = Image.FromFile(@"C:\Users\suporte\Downloads\olho_aberto.png");
                }
                else
                {
                    txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;
                    pb_olho.Image = Image.FromFile(@"C:\Users\suporte\Downloads\fechar_olho.png");
                }

            }
            catch
            {

            }
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.AppStarting;

            string HashSenha = txbSenha.Text;
            string login = txtlogin.Text;

            using (var db = new EstoqueContext())
            {
                usuario = db.Usuarios.FirstOrDefault(x => x.login == login);
            }

            if (usuario != null)
            {

                StringBuilder sb = new StringBuilder();

                using (SHA512 sha512 = SHA512.Create())
                {

                    byte[] hashvalue = sha512.ComputeHash(Encoding.UTF8.GetBytes(HashSenha));
                    foreach (byte b in hashvalue)
                    {
                        sb.Append($"({b:x2})");

                    }
                }

                HashSenha = sb.ToString();

                if (usuario.HashSenha == HashSenha)
                {
                    /*
                    this.Hide();

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    */
                    MessageBox.Show("Sucesso");
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorreta");
                }

            }
            else
            {
                var result = MessageBox.Show(
                    "Acesso negado ao usuário, tente novamente",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                 );
            }

            this.Cursor = Cursors.Default;
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}