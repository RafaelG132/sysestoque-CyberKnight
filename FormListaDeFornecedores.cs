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
    public partial class FormListaDeFornecedores : Form
    {
        public FormListaDeFornecedores()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                BindingSource dgFornecedores = new BindingSource();
                dgFornecedores.DataSource = db.Fornecedores.ToList();

                dgvFornecedores.DataSource = dgFornecedores;
            }
        }

        private void FormListaDeFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                FormNotaEntrada.fornecedor = dgvFornecedores.SelectedRows[0].DataBoundItem as Fornecedor;
            }

        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
