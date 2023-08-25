using Microsoft.EntityFrameworkCore;
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

namespace sysestoque_CyberKnight{
    public partial class FormPrincipal : Form{
        ICollection<Produto> listaProdutos = new List<Produto>();
        BindingSource bindingSourceProdutos = new BindingSource();
        Produto produto = new Produto();

        public FormPrincipal() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {

                db.Database.GetConnectionString();


                listaProdutos = db.Produtos
                                         .Include( p => p.Categoria)
                                         .Include( p => p.UnidadeMedida)
                                         .Include( p => p.Fornecedores)
                                         .ToList();

                bindingSourceProdutos.DataSource = listaProdutos;

                dgvProdutoTelaPrincipal.DataSource = bindingSourceProdutos;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) {

        }
    }
}
