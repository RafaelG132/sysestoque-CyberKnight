﻿using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_CyberKnight
{
    public partial class FormCadastroDeCategorias : Form
    {
        ICollection<Categoria> listaCategoria = new List<Categoria>();
        BindingSource bindingSourceCategorias = new BindingSource();
        Categoria categoria = new Categoria();

        private bool EstaAtualizando = false;

        public FormCadastroDeCategorias()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {

                db.Database.GetConnectionString();


                listaCategoria = db.Categorias.ToList();

                bindingSourceCategorias.DataSource = listaCategoria;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvCategoria.SelectedRows.Count > 0)
            {

                categoria = (dgvCategoria.SelectedRows[0].DataBoundItem as Categoria);

                //Remove a categoria do DataGridView
                bindingSourceCategorias.Remove(categoria);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext())
                {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();

                }

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            categoria.Id = null;
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;

            if (EstaAtualizando)
            {

                categoria.Id = int.Parse(txtId.Text);

                using (var db = new EstoqueContext())
                {
                    db.Categorias.Update(categoria);
                    db.SaveChanges();

                    listaCategoria = db.Categorias.ToList();

                    bindingSourceCategorias.DataSource = listaCategoria;

                    dgvCategoria.DataSource = bindingSourceCategorias;

                    dgvCategoria.Refresh();
                }


                EstaAtualizando = false;

            }
            else
            {

                using (var db = new EstoqueContext())
                {
                    db.Categorias.Add(categoria);
                    db.SaveChanges();

                    listaCategoria = db.Categorias.ToList();

                    bindingSourceCategorias.DataSource = listaCategoria;

                    dgvCategoria.DataSource = bindingSourceCategorias;

                    dgvCategoria.Refresh();
                }

            }

            txtId.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                categoria = (dgvCategoria.SelectedRows[0].DataBoundItem as Categoria);

                txtId.Text = categoria.Id.ToString();
                txtNome.Text = categoria.Nome;
                txtDescricao.Text = categoria.Descricao;

                EstaAtualizando = true;

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}