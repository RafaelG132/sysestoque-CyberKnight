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
    public partial class FormFornecedor : Form{
        ICollection<Fornecedor> fornecedor = new List<Fornecedor>();
        BindingSource bindingSourceFornecedor= new BindingSource();

        public FormFornecedor(){
            InitializeComponent();

            using (var db = new EstoqueContext()){
                fornecedor = db.Fornecedores.ToList();

                bindingSourceFornecedor.DataSource = fornecedor;

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
    }
}
