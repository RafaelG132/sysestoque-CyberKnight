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
    public partial class FormNotaEntrada : Form
    {
        public static ICollection<Produto> produtos { get; set; } = new List<Produto>();
        public static BindingSource? sourceProdutos { get; set; } = new BindingSource();
        private NotaEntrada notaEntrada { get; set; } = new NotaEntrada();
        public static Fornecedor fornecedor { get; set; }

        public FormNotaEntrada()
        {
            InitializeComponent();
        }

        private void FormNotaEntrada_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListaDeFornecedores formListaDeFornecedores = new FormListaDeFornecedores();
            formListaDeFornecedores.ShowDialog();

            txbCnpj.Text = FormNotaEntrada.fornecedor.Cnpj;
            txbEmail.Text = FormNotaEntrada.fornecedor.Email;
            txbEndereço.Text = FormNotaEntrada.fornecedor.Endereco;
            txbTelefone.Text = FormNotaEntrada.fornecedor.Telefone;
        }
    }
}
