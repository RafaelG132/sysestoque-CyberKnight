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
    public partial class FormFornecedor : Form
    {
        ICollection<Fornecedor> listaFornecedor = new List<Fornecedor>();
        BindingSource bindingSourceFornecedor = new BindingSource();
        Fornecedor fornecedor = new Fornecedor();

        private bool EstaAtualizando = false;

        public FormFornecedor()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                listaFornecedor = db.Fornecedores.ToList();

                bindingSourceFornecedor.DataSource = listaFornecedor;

                dgvFornecedor.DataSource = bindingSourceFornecedor;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {

                fornecedor = (dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);

                //Remove a categoria do DataGridView
                bindingSourceFornecedor.Remove(listaFornecedor);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext())
                {
                    db.Fornecedores.Remove(fornecedor);
                    db.SaveChanges();

                }

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (EstaAtualizando)
            {
                //Pega o dado formulário e atualiza no banco de dados
                EstaAtualizando = false;

            }
            else
            {
                //Pega o dado formulário e vai inserir no banco de dados
            }

            fornecedor.Cnpj = txtCNPJ.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Telefone = txtTelefone.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Responsavel = txtResponsavel.Text;

            using (var db = new EstoqueContext())
            {
                db.Fornecedores.Add(fornecedor);
                db.SaveChanges();

                listaFornecedor = db.Fornecedores.ToList();

                bindingSourceFornecedor.DataSource = listaFornecedor;

                dgvFornecedor.DataSource = bindingSourceFornecedor;

                dgvFornecedor.Refresh();

            }


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                fornecedor = (dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);

                txtCNPJ.Text = fornecedor.Cnpj.ToString();
                txtNome.Text = fornecedor.Nome;
                txtEndereco.Text = fornecedor.Endereco;
                txtTelefone.Text = fornecedor.Telefone;
                txtEmail.Text = fornecedor.Email;
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtResponsavel.Text = fornecedor.Responsavel;

                EstaAtualizando = true;

            }
        }
    }
}
