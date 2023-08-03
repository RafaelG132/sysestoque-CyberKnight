using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    internal class EstoqueContext : DbContext{
        // Cadastrando para EFCore a classe que vai
        // se transformar em tabela no banco de dados
        public DbSet <Usuario> Usuarios { get; set; }

        //public DbSet<NotaEntrada> NotaEntradas { get; set; }

        protected override void
            OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySQL("Server=127.0.0.1;port=3306;database=estoque;uid=root;password=#Root2022");


        }

    }
}
