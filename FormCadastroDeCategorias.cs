using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight
{
    public partial class FormCadastroDeCategorias : Form
    {
        ICollection<Categoria> listaCategoria = new List<Categoria>();
        BindingSource bindingSourceCategorias = new BindingSource();
        Categoria categoria = new Categoria();

        private bool EstaAtualizando = false;

        public FormCadastroDeCategorias()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {

                db.Database.GetConnectionString();


                listaCategoria = db.Categorias.ToList();

                bindingSourceCategorias.DataSource = listaCategoria;

                dgvCategoria.DataSource = bindingSourceCategorias;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormCadastroDeCategorias_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dgvCategoria.SelectedRows.Count > 0){
             var result = MessageBox.Show("Você realmente deseja excluir essa informação?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    categoria = (dgvCategoria.SelectedRows[0].DataBoundItem as Categoria);

                    //Remove a categoria do DataGridView
                    bindingSourceCategorias.Remove(categoria);

                    //Remove do Banco de Dados
                    using (var db = new EstoqueContext())
                    {
                        db.Categorias.Remove(categoria);
                        db.SaveChanges();

                    }
                }
            }
            else
            {
                //msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                //msgBarraStatus.ForeColor = Color.Red;

            }



            this.Cursor = Cursors.Default;

        }

        private bool ValidarCampos()
        {

            bool estaValido = true;

            //Nome
            if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.Red;

                estaValido = false;
            }
            //Descrição
            if (txtDescricao.Text == "")
            {
                txtDescricao.BackColor = Color.Red;
                estaValido = false;
            }

            RestaurarEstiloTxt();

            return estaValido;
        }

        private async Task<bool> RestaurarEstiloTxt()
        {
            await Task.Delay(5000);
            //msgBarraStatus.Text = "";

            txtNome.BackColor = Color.White;
            txtDescricao.BackColor = Color.White;

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                if (!this.ValidarCampos()){
                    return;
                }

                categoria.Id = null;
                categoria.Nome = txtNome.Text;
                categoria.Descricao = txtDescricao.Text;

                if (EstaAtualizando)
                {

                    categoria.Id = int.Parse(txtId.Text);

                    using (var db = new EstoqueContext())
                    {
                        db.Categorias.Update(categoria);
                        db.SaveChanges();

                        listaCategoria = db.Categorias.ToList();

                        bindingSourceCategorias.DataSource = listaCategoria;

                        dgvCategoria.DataSource = bindingSourceCategorias;

                        dgvCategoria.Refresh();
                    }


                    EstaAtualizando = false;

                }
                else
                {

                    using (var db = new EstoqueContext())
                    {
                        db.Categorias.Add(categoria);
                        db.SaveChanges();

                        listaCategoria = db.Categorias.ToList();

                        bindingSourceCategorias.DataSource = listaCategoria;

                        dgvCategoria.DataSource = bindingSourceCategorias;

                        dgvCategoria.Refresh();
                    }

                }

                categoria.Nome = "";
                categoria.Descricao = "";

                txtId.Text = "";
                txtNome.Text = "";
                txtDescricao.Text = "";

                this.Cursor = Cursors.Default;


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            if (dgvCategoria.SelectedRows.Count > 0)
            {
                categoria = (dgvCategoria.SelectedRows[0].DataBoundItem as Categoria);

                txtId.Text = categoria.Id.ToString();
                txtNome.Text = categoria.Nome;
                txtDescricao.Text = categoria.Descricao;

                EstaAtualizando = true;

            }
            else
            {
                msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                msgBarraStatus.ForeColor = Color.Red;

                RestaurarEstiloTxt();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
