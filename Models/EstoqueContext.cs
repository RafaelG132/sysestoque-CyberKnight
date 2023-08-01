﻿using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    public class EstoqueContext : DbContext{
        // Cadastrando para EFCore a classe que vai
        // se transformar em tabela no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<NotaEntrada> NotasEntrada { get; set; }
        public DbSet<Fornecedor> Forncedores { get; set; }
        public DbSet<ItemEntrada> ItemEntrada { get; set; }
        public DbSet<ItemSaida> ItemSaida { get; set; }
        public DbSet<NotaSaida> NotaSaida { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //public DbSet<NotaEntrada> NotaEntradas { get; set; }

        protected override void
            OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySQL("Server=127.0.0.1;port=3306;database=estoque;uid=root;password=#Root2022");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            new ItemNotaEntradaConfig().Configure(modelBuilder.Entity<ItemEntrada>());

            new ItemNotaSaidaConfig().Configure(modelBuilder.Entity<ItemSaida>());

            new NotaEntradaConfig().Configure(modelBuilder.Entity<NotaEntrada>());

            new NotaSaidaConfig().Configure(modelBuilder.Entity<NotaSaida>());



        }

    }
}
