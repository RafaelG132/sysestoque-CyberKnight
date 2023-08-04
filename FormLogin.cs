using sysestoque_CyberKnight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text;
            string senha = txbSenha.Text;

            Usuario usuario = null;
            // Busca o usuário no banco de dados
            using (var db = new EstoqueContext())
            {
                usuario = db.Usuarios.FirstOrDefault(u => u.login == login);

            }

            if (usuario != null)
            {
                //Teste da senha
                if (usuario.login == login)
                {
                    //Bloco de código caso a senha do banco de dados seja igual a senha digitada pelo usuário
                    MessageBox.Show("Usuário logado com sucesso");
                }
                else
                {
                    //Bloco de código caso a senha seja diferente
                    MessageBox.Show("Acesso negado");
                }
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;

        }
    }
}

