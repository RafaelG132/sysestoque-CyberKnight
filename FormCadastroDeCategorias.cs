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
    public partial class FormCadastroDeCategorias : Form
    {
        ICollection<Categoria> categorias = new List<Categoria>();
        BindingSource bindingSourceCategorias = new BindingSource();
        public FormCadastroDeCategorias()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                categorias = db.Categorias.ToList();

                bindingSourceCategorias.DataSource = categorias;

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
    }
}
