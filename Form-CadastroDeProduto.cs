using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models;
using sysestoque_CyberKnight.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight
{
    public partial class Form_CadastroDeProduto : Form
    {


        BindingSource bindingSourceProdutos = new BindingSource();

        private bool EstaAtualizando = false;
        public static ICollection<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ICollection<Produto> produtos = new List<Produto>();
        Produto produto = new Produto();

        public Form_CadastroDeProduto()
        {


            InitializeComponent();

            dgv_Produto.AutoGenerateColumns = false;

            using (var db = new EstoqueContext())
            {
                cbxProdCategoria.DataSource = db.Categorias.ToList();
                cbxProdCategoria.DisplayMember = "Name";
                cbxProdCategoria.ValueMember = "Id";
                cbxProdCategoria.SelectedIndex = -1;

                cbxProdUnidMedida.DataSource = db.UnidadeMedida.ToList();
                cbxProdUnidMedida.DisplayMember = "Name";
                cbxProdUnidMedida.ValueMember = "Id";
                cbxProdUnidMedida.SelectedIndex = -1;

                produtos = db.Produtos
                .Include(i => i.categoria)
                .Include(i => i.UnidadeMedida)
                .ToList();

                bindingSourceProdutos.DataSource = produtos;

                dgv_Produto.DataSource = bindingSourceProdutos;
            }
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dgv_Produto.SelectedRows.Count > 0)
            {

                produto = dgv_Produto.SelectedRows[0].DataBoundItem as Produto;

                bindingSourceProdutos.Remove(produto);

                using (var db = new EstoqueContext())
                {
                    db.Produtos.Remove(produto);
                    db.SaveChanges();


                    this.Cursor = Cursors.Default;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (EstaAtualizando)
            {

            }
            else
            {
                produto.id = null;
                produto.CategoriaId = (int)cbxProdCategoria.SelectedValue;
                produto.estoque = txtqtd.Text;
                produto.descricao = txtdescricao.Text;
                produto.precounit = txtprecounit.Text;
                produto.estoqueMax = float.Parse(txtestoquemax.Text);
                produto.estoqueMedio = float.Parse(txtestoquemedio.Text);
                produto.estoqueMin = float.Parse(txtestoqueMin.Text);

                using (var db = new EstoqueContext())
                {
                    db.Produtos.Add(produto);
                    db.SaveChanges();

                    produtos = db.Produtos.ToList();

                    bindingSourceProdutos.DataSource = produtos;

                    dgv_Produto.DataSource = bindingSourceProdutos;
                    dgv_Produto.Refresh();

                    this.Cursor = Cursors.Default;
                }
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            if (dgv_Produto.SelectedRows.Count > 0)
            {
                produto = dgv_Produto.SelectedRows[0].DataBoundItem as Produto;
            }
        }

        private void dgv_Produto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (
                (dgv_Produto.Rows[e.RowIndex].DataBoundItem != null) &&
                (dgv_Produto.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
                )
            {

                e.Value = BindProperty.resolve(
                            dgv_Produto.Rows[e.RowIndex].DataBoundItem,
                            dgv_Produto.Columns[e.ColumnIndex].DataPropertyName
                        );
            }
        }
        private void dgv_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}





