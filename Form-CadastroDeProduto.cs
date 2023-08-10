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
    public partial class Form_CadastroDeProduto : Form{

        ICollection<Produto> Produtos = new List<Produto>();
        BindingSource bindingSourceProdutos = new BindingSource();
        Produto Produto = new Produto();
        public Form_CadastroDeProduto()
        {

            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                Produtos = db.Produtos.ToList();

                bindingSourceProdutos.DataSource = Produtos;

                dgv_Produto.DataSource = bindingSourceProdutos;
            }
        }
        

        private void label1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void Form_CadastroDeProduto_Load(object sender, EventArgs e)
        {

        }

        private void lbl_produtos_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (dgv_Produto.SelectedRows.Count > 0) {
                
                Produto = dgv_Produto.SelectedRows[0].DataBoundItem as Produto;

                bindingSourceProdutos.Remove(Produto);

                using (var db = new EstoqueContext()) {
                    db.Produtos.Remove(Produto);
                    db.SaveChanges();




        }
    }
}
