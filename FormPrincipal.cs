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
        ICollection<Produto> listaProduto = new List<Produto>();
        BindingSource bindingSourceProduto = new BindingSource();
        Produto produto = new Produto();

        public FormPrincipal() {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e) {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) {

        }
    }
}
