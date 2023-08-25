﻿using sysestoque_CyberKnight.Models;
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
    public partial class FormFornecedor : Form {
        ICollection<Fornecedor> listaFornecedor = new List<Fornecedor>();
        BindingSource bindingSourceFornecedor = new BindingSource();
        Fornecedor fornecedor = new Fornecedor();

        private bool EstaAtualizando = false;

        public FormFornecedor() {
            InitializeComponent();

            using (var db = new EstoqueContext()) {
                listaFornecedor = db.Fornecedores.ToList();

                bindingSourceFornecedor.DataSource = listaFornecedor;

                dgvFornecedor.DataSource = bindingSourceFornecedor;
            }

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void FormFornecedor_Load(object sender, EventArgs e) {

        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;


            if (dgvFornecedor.SelectedRows.Count > 0) {
                var result = MessageBox.Show("Você realmente deseja excluir essa informação?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {

                    fornecedor = (dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);


                    //Remove do Banco de Dados
                    using (var db = new EstoqueContext()) {
                        db.Fornecedores.Remove(fornecedor);
                        db.SaveChanges();

                        //Remove a categoria do DataGridView
                        listaFornecedor = db.Fornecedores.ToList();
                        bindingSourceFornecedor.DataSource = listaFornecedor;
                        dgvFornecedor.DataSource = bindingSourceFornecedor;
                    }

                }

            } else {
                //msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                //msgBarraStatus.ForeColor = Color.Red;

            }

            this.Cursor = Cursors.Default;
        }

        private bool ValidarCampos() {

            bool estaValido = true;

            //Nome
            if (txtNome.Text == "") {
                txtNome.BackColor = Color.Red;

                estaValido = false;
            }
            //CNPJ
            if (txtCNPJ.Text == "") {
                txtCNPJ.BackColor = Color.Red;

                estaValido = false;
            }
            //Endereço
            if (txtEndereco.Text == "") {
                txtEndereco.BackColor = Color.Red;

                estaValido = false;

            }
            //Telefone
            if (txtTelefone.Text == "") {
                txtTelefone.BackColor = Color.Red;

                estaValido = false;

            } //Email
            if (txtEmail.Text == "") {
                txtEmail.BackColor = Color.Red;

                estaValido = false;

            }
            //Razão Social
            if (txtRazaoSocial.Text == "") {
                txtRazaoSocial.BackColor = Color.Red;

                estaValido = false;
            }
            //Responsável
            if (txtResponsavel.Text == "") {
                txtResponsavel.BackColor = Color.Red;

                estaValido = false;

            }
            RestaurarEstiloTxt();

            return estaValido;

        }

        private async Task<bool> RestaurarEstiloTxt() {
            await Task.Delay(5000);
            //msgBarraStatus.Text = "";

            txtNome.BackColor = Color.White;
            txtCNPJ.BackColor = Color.White;
            txtEndereco.BackColor = Color.White;
            txtTelefone.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtRazaoSocial.BackColor = Color.White;
            txtResponsavel.BackColor = Color.White;

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {

            try {

                this.Cursor = Cursors.WaitCursor;

                if (!this.ValidarCampos()) {
                    return;
                }


                fornecedor.Cnpj = txtCNPJ.Text;
                fornecedor.Nome = txtNome.Text;
                fornecedor.Endereco = txtEndereco.Text;
                fornecedor.Telefone = txtTelefone.Text;
                fornecedor.Email = txtEmail.Text;
                fornecedor.RazaoSocial = txtRazaoSocial.Text;
                fornecedor.Responsavel = txtResponsavel.Text;

                if (EstaAtualizando) {

                    fornecedor.Cnpj = txtCNPJ.Text;

                    using (var db = new EstoqueContext()) {
                        db.Fornecedores.Update(fornecedor);
                        db.SaveChanges();

                        listaFornecedor = db.Fornecedores.ToList();

                        bindingSourceFornecedor.DataSource = listaFornecedor;

                        dgvFornecedor.DataSource = bindingSourceFornecedor;

                        dgvFornecedor.Refresh();

                    }

                    EstaAtualizando = false;

                } else {

                    using (var db = new EstoqueContext()) {
                        db.Fornecedores.Add(fornecedor);
                        db.SaveChanges();

                        listaFornecedor = db.Fornecedores.ToList();

                        bindingSourceFornecedor.DataSource = listaFornecedor;

                        dgvFornecedor.DataSource = bindingSourceFornecedor;

                        dgvFornecedor.Refresh();

                    }
                }

                fornecedor.Cnpj = "";
                fornecedor.Nome = "";
                fornecedor.Endereco = "";
                fornecedor.Telefone = "";
                fornecedor.Email = "";
                fornecedor.RazaoSocial = "";
                fornecedor.Responsavel = "";

                txtCNPJ.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtRazaoSocial.Text = "";
                txtResponsavel.Text = "";

                this.Cursor = Cursors.Default;

            } catch (Exception erro) {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e) {

        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            if (dgvFornecedor.SelectedRows.Count > 0) {
                fornecedor = (dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);

                txtCNPJ.Text = fornecedor.Cnpj.ToString();
                txtNome.Text = fornecedor.Nome;
                txtEndereco.Text = fornecedor.Endereco;
                txtTelefone.Text = fornecedor.Telefone;
                txtEmail.Text = fornecedor.Email;
                txtRazaoSocial.Text = fornecedor.RazaoSocial;
                txtResponsavel.Text = fornecedor.Responsavel;

                EstaAtualizando = true;

            } else {
                msgBarraStatus.Text = "Você deve selecionar uma linha para poder excluir";
                msgBarraStatus.ForeColor = Color.Red;

                RestaurarEstiloTxt();
            }
        }
    }
}
