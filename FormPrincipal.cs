using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models;
using sysestoque_CyberKnight.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight {
    public partial class FormPrincipal : Form {
        ICollection<Produto> listaProdutos = new List<Produto>();
        BindingSource bindingSourceProdutos = new BindingSource();
        Produto produto = new Produto();

        public FormPrincipal() {
            InitializeComponent();
            dgvProdutoTelaPrincipal.AutoGenerateColumns = false;

            using (var db = new EstoqueContext()) {

                db.Database.GetConnectionString();


                listaProdutos = db.Produtos
                                         .Include(p => p.Categoria)
                                         .Include(p => p.UnidadeMedida)
                                         .Include(p => p.Fornecedores)
                                         .ToList();

                bindingSourceProdutos.DataSource = listaProdutos;

                dgvProdutoTelaPrincipal.DataSource = bindingSourceProdutos;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) {

        }

        private void dgvProdutoTelaPrincipal_Click(object sender, EventArgs e) {
            if (dgvProdutoTelaPrincipal.SelectedRows.Count > 0) {
                produto = dgvProdutoTelaPrincipal.SelectedRows[0].DataBoundItem as Produto;

                txtEstoqueMinimo.Text = produto.estoqueMin.ToString();
                txtEstoqueMedio.Text = produto.estoqueMedio.ToString();
                txtEstoqueMaximo.Text = produto.estoqueMax.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void dgvProdutoTelaPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (
                (dgvProdutoTelaPrincipal.Rows[e.RowIndex].DataBoundItem != null) &&
                (dgvProdutoTelaPrincipal.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
                ) {

                e.Value = BindProperty.resolve(
                            dgvProdutoTelaPrincipal.Rows[e.RowIndex].DataBoundItem,
                            dgvProdutoTelaPrincipal.Columns[e.ColumnIndex].DataPropertyName
                        );
            }
        }

        private void dgvProdutoTelaPrincipal_SelectionChanged(object sender, EventArgs e) {
            if (dgvProdutoTelaPrincipal.SelectedRows.Count > 0) {
                var produtoAtual = dgvProdutoTelaPrincipal.SelectedRows[0].DataBoundItem as Produto;

                txtEstoqueMinimo.Text = produtoAtual.estoqueMin.ToString();
                txtEstoqueMedio.Text = produtoAtual.estoqueMedio.ToString();
                txtEstoqueMaximo.Text = produtoAtual.estoqueMax.ToString();
            }
        }

        private void dgvProdutoTelaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
