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
    public partial class Form_Unidade_de_Medida : Form
    {

        ICollection<UnidadeMedida> listaUnidadeMedida = new List<UnidadeMedida>();
        BindingSource bindingSourceUnidadeMedida = new BindingSource();
        UnidadeMedida unidadeMedida = new UnidadeMedida();

        public Form_Unidade_de_Medida()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                unidadeMedidas = db.UnidadeMedida.ToList();

                bindingSourceUnidadeMedida.DataSource = unidadeMedidas;

                dgvUnidade_medida.DataSource = bindingSourceUnidadeMedida;
            }
        }

        private void Form_Unidade_de_Medida_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgvUnidade_medida.SelectedRows.Count > 0)
            {

                unidadeMedida = dgvUnidade_medida.SelectedRows[0].DataBoundItem as UnidadeMedida;

                bindingSourceUnidadeMedida.Remove(unidadeMedida);

                using (var db = new EstoqueContext())
                {
                    db.UnidadeMedida.Remove(unidadeMedida);
                    db.SaveChanges();
                }
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            unidadeMedida.Id = null;
            unidadeMedida.Sigla = txbSigla.Text;
            unidadeMedida.NomeExtenso = txtNome.Text;

            using (var db = new EstoqueContext())
            {
                db.UnidadeMedida.Add(unidadeMedida);
                db.SaveChanges();

                listaUnidadeMedida = db.UnidadeMedida.ToList();

                bindingSourceUnidadeMedida.DataSource = listaUnidadeMedida;

                dgvUnidade_medida.DataSource = bindingSourceUnidadeMedida;
                dgvUnidade_medida.Refresh();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}




