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
using System.Security.Cryptography;

namespace sysestoque_CyberKnight
{
    public partial class FormUsuario : Form
    {
        ICollection<Usuario> usuarios = new List<Usuario>();
        BindingSource bindingSourceUsuarios = new BindingSource();
        Usuario usuario = new Usuario();

        private bool EstaAtualizando = false;

        public FormUsuario()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {

                usuarios = db.Usuarios.ToList();
                bindingSourceUsuarios.DataSource = usuario;
                dgvUsuario.DataSource = bindingSourceUsuarios;
            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var result = MessageBox.Show("Voçê realmente deseja excluir esse item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){

            }


            if (dgvUsuario.SelectedRows.Count > 0)
            {
                usuario = (dgvUsuario.SelectedRows[0].DataBoundItem as Usuario);

                //Remove a categoria do DataGridView
                bindingSourceUsuarios.Remove(usuario);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext())
                {
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                }
            }else{
                msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                msgBarraStatus.ForeColor = Color.Red;

            } 

            this.Cursor = Cursors.Default;
        }

        private bool validarCampos()
        {
            bool estaValidado = true;
            //CPF
            if (txbCpf.Text == "")
            {
                txbCpf.BackColor = Color.Red;

                estaValidado = false;
            }
            //Nome
            if (txbNome.Text == "")
            {
                txbNome.BackColor = Color.Red;

                estaValidado = false;
            }
            //Login
            if (txbLogin.Text == "")
            {
                txbLogin.BackColor = Color.Red;

                estaValidado = false;
            }
            //Senha
            if (txbSenha.Text == "")
            {
                txbSenha.BackColor = Color.Red;

                estaValidado = false;
            }
            //Telefone
            if (txbTelefone.Text == "")
            {
                txbTelefone.BackColor = Color.Red;

                estaValidado = false;
            }

            RestaurarEstiloTxb();

            return estaValidado;
        }

        private async Task<bool> RestaurarEstiloTxb()
        {
            // Seta um delay em milisegundos			
            await Task.Delay(5000);

            //Executa o precesso de restauração de
            //estado padrão dos campos
            msgBarraStatus.Text = "";

            txbNome.BackColor = Color.White;
            txbLogin.BackColor = Color.White;
            txbCpf.BackColor = Color.White;
            txbSenha.BackColor = Color.White;
            txbTelefone.BackColor = Color.White;

            // Retorna o valro boleano
            return true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            if (!this.validarCampos())
            {
                return;
            }

            StringBuilder sb = new StringBuilder(); {

                using (SHA512 sha512 =sha512.create)) {
                    byte[] hashValue = sha512.ComputeHash(Encoding.UTF8.GetBytes(senha))

                }
            }

            usuario.HashSenha = txbSenha.Text;

            usuario.cpf = txbCpf.Text;
            usuario.nome = txbNome.Text;
            usuario.login = txbLogin.Text;
            usuario.telefone = txbTelefone.Text;

            if (EstaAtualizando)
            {

                usuario.login = txbLogin.Text;

                using (var db = new EstoqueContext())
                {
                    db.Usuarios.Update(usuario);
                    db.SaveChanges();

                    usuarios = db.Usuarios.ToList();
                    bindingSourceUsuarios.DataSource = usuarios;
                    dgvUsuario.DataSource = bindingSourceUsuarios;
                    dgvUsuario.Refresh();

                }

                EstaAtualizando = false;


            }
            else
            {

                using (var db = new EstoqueContext())
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();

                    usuarios = db.Usuarios.ToList();
                    bindingSourceUsuarios.DataSource = usuarios;
                    dgvUsuario.DataSource = bindingSourceUsuarios;
                    dgvUsuario.Refresh();

                }
            }

            usuario.cpf = "";
            usuario.nome = "";
            usuario.login = "";
            usuario.HashSenha = "";
            usuario.telefone = "";

            txbCpf.Text = "";
            txbNome.Text = "";
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbTelefone.Text = "";


            this.Cursor = Cursors.Default;



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {

                usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                txbCpf.Text = usuario.cpf.ToString();
                txbNome.Text = usuario.nome;
                txbLogin.Text = usuario.login;
                txbTelefone.Text = usuario.telefone;

                EstaAtualizando = true;
            }
            else{
                msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                msgBarraStatus.ForeColor = Color.Red;

                RestaurarEstiloTxb();
            }
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
