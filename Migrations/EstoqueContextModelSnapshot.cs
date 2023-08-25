﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sysestoque_CyberKnight.Models;

#nullable disable

namespace sysestoque_CyberKnight.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    partial class EstoqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.Property<string>("FornecedoresCnpj")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("produtosid")
                        .HasColumnType("int");

                    b.HasKey("FornecedoresCnpj", "produtosid");

                    b.HasIndex("produtosid");

                    b.ToTable("FornecedorProduto");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Categoria", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Fornecedor", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("longtext");

                    b.Property<string>("Responsavel")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Cnpj");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.ItemEntrada", b =>
                {
                    b.Property<int>("NotaEntradaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Qtd")
                        .HasColumnType("int");

                    b.HasKey("NotaEntradaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemEntrada");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.ItemSaida", b =>
                {
                    b.Property<int>("NotaSaidaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Qtd")
                        .HasColumnType("int");

                    b.HasKey("NotaSaidaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItemSaida");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.NotaEntrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Numeracao")
                        .HasColumnType("int");

                    b.Property<string>("ResponsavelEntradalogin")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<string>("fornecedorCnpj")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ResponsavelEntradalogin");

                    b.HasIndex("fornecedorCnpj");

                    b.ToTable("NotasEntrada");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.NotaSaida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NotaSaida");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeMedidaId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("estoque")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("estoqueMax")
                        .HasColumnType("float");

                    b.Property<float>("estoqueMedio")
                        .HasColumnType("float");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("unidadeMedida")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UnidadeMedidaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.UnidadeMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeExtenso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UnidadeMedida");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Usuario", b =>
                {
                    b.Property<string>("login")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("HashSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("login");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FornecedorProduto", b =>
                {
                    b.HasOne("sysestoque_CyberKnight.Models.Fornecedor", null)
                        .WithMany()
                        .HasForeignKey("FornecedoresCnpj")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_CyberKnight.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("produtosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.ItemEntrada", b =>
                {
                    b.HasOne("sysestoque_CyberKnight.Models.NotaEntrada", "NotaEntrada")
                        .WithMany("ItensEntrada")
                        .HasForeignKey("NotaEntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_CyberKnight.Models.Produto", "Produto")
                        .WithMany("ItensEntrada")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaEntrada");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.ItemSaida", b =>
                {
                    b.HasOne("sysestoque_CyberKnight.Models.NotaSaida", "NotaSaida")
                        .WithMany("ItensSaida")
                        .HasForeignKey("NotaSaidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_CyberKnight.Models.Produto", "Produto")
                        .WithMany("ItensSaida")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaSaida");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.NotaEntrada", b =>
                {
                    b.HasOne("sysestoque_CyberKnight.Models.Usuario", "ResponsavelEntrada")
                        .WithMany()
                        .HasForeignKey("ResponsavelEntradalogin");

                    b.HasOne("sysestoque_CyberKnight.Models.Fornecedor", "fornecedor")
                        .WithMany("NFs")
                        .HasForeignKey("fornecedorCnpj");

                    b.Navigation("ResponsavelEntrada");

                    b.Navigation("fornecedor");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Produto", b =>
                {
                    b.HasOne("sysestoque_CyberKnight.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sysestoque_CyberKnight.Models.UnidadeMedida", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("UnidadeMedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Fornecedor", b =>
                {
                    b.Navigation("NFs");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.NotaEntrada", b =>
                {
                    b.Navigation("ItensEntrada");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.NotaSaida", b =>
                {
                    b.Navigation("ItensSaida");
                });

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Produto", b =>
                {
                    b.Navigation("ItensEntrada");

                    b.Navigation("ItensSaida");
                });
#pragma warning restore 612, 618
        }
    }
}
