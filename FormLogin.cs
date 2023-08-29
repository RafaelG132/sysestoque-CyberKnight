using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using sysestoque_CyberKnight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

            using (var db = new EstoqueContext())
            {
                if (db.Usuarios.Count() <= 0)
                {
                    Usuario userDesault = new Usuario();

                    userDesault.cpf = "658.548.148.48";
                    userDesault.nome = "Fulano";
                    userDesault.login = "Admin";
                    userDesault.telefone = "() -";
                    
                    StringBuilder sb = new StringBuilder();

                    using (SHA512 sha512 = SHA512.Create())
                    {
                        byte[] hashvalue = sha512.ComputeHash(Encoding.UTF8.GetBytes("qwer1234"));
                        foreach (byte b in hashvalue)
                        {
                            sb.Append($"({b:x2})");

                        }
                    }

                    userDesault.HashSenha = sb.ToString();



                    db.Usuarios.Add(userDesault);
                    db.SaveChanges();
                }
            }
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
            string login = txblogin.Text;

            using (var db = new EstoqueContext())
            {
                usuario = db.Usuarios.FirstOrDefault(x => x.login == login);
            }

            if (usuario != null)
            {
                //utilizando a classe para construir nossa string
                StringBuilder sb = new StringBuilder();

                using (SHA512 sha512 = SHA512.Create())
                {

                     //criptografando a senha inserida pelo usuário
                    // para compara com a senha guardada no banco de dados
                    byte[] hashvalue = sha512.ComputeHash(Encoding.UTF8.GetBytes(HashSenha));
                    foreach (byte b in hashvalue)
                    {
                        sb.Append($"({b:x2})");

                    }
                }

                HashSenha = sb.ToString();

                if (HashSenha == usuario.HashSenha)
                {
                    /*
                    this.Hide();

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    */
                    var result = MessageBox.Show(
                        "Acesso Concedido",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None
                   );

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