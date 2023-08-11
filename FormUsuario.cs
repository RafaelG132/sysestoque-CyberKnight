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
                bindingSourceUsuarios.DataSource = usuarios;
                dgvUsuario.DataSource = bindingSourceUsuarios;
            }

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e){

            if (EstaAtualizando) {
                //Pegar o dado formulario e atualiza no banco de dados
                EstaAtualizando = false;


            } else{
                //Pegar o dado fromulario e vai inserir no banco de  dados
            } 





            usuario.cpf = txbCpf.Text;
            usuario.nome = txbNome.Text;
            usuario.login = txbLogin.Text;
            usuario.HashSenha = txbSenha.Text;
            usuario.telefone = txbTelefone.Text;

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

        private void btnAtualizar_Click(object sender, EventArgs e){
            if (dgvUsuario.SelectedRows.Count > 0) {

                usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                txbCpf.Text = usuario.cpf.ToString();
                txbNome.Text = usuario.nome;
                txbLogin.Text = usuario.login;
                txbTelefone.Text = usuario.telefone;

                EstaAtualizando = true; 
            }
        }
    }
}
