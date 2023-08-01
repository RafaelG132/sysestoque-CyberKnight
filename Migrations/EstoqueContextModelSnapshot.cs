﻿// <auto-generated />
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

            modelBuilder.Entity("sysestoque_CyberKnight.Models.Usuario", b =>
                {
                    b.Property<string>("nome")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("HashSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("nome");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}