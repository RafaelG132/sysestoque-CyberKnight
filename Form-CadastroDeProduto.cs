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
    public partial class Form_CadastroDeProduto : Form
    {

        ICollection<Produto> produtos = new List<Produto>();
        BindingSource bindingSourceProdutos = new BindingSource();

        Produto produto = new Produto();

        private bool EstaAtualizando = false;

        public Form_CadastroDeProduto()
        {

            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                produtos = db.Produtos.ToList();

                bindingSourceProdutos.DataSource = produtos;

                dgv_Produto.DataSource = bindingSourceProdutos;
            }
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (dgv_Produto.SelectedRows.Count > 0)
            {

                produto = dgv_Produto.SelectedRows[0].DataBoundItem as Produto;

                bindingSourceProdutos.Remove(produto);

                using (var db = new EstoqueContext())
                {
                    db.Produtos.Remove(produto);
                    db.SaveChanges();




                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (EstaAtualizando)
            {

            }
            else
            {
                produto.id = null;
                produto.categoria = txtcategoria.Text;
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

                }
            }






        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (dgv_Produto.SelectedRows.Count > 0){
                produto = dgv_Produto.SelectedRows[0].DataBoundItem as Produto;

                
            }
        }
    }

}