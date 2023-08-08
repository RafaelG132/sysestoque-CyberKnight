using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models.Config;

namespace sysestoque_CyberKnight.Models{
    [EntityTypeConfiguration(typeof(NotaEntradaConfig))]
    public class NotaEntrada{
        [Key]     
            public int Id { get; set; }
            public DateTime DataEntrada { get; set; }

            public float ValorTotal { get; set; }

            public Fornecedor fornecedor { get; set; } = new Fornecedor();


            public Usuario? ResponsavelEntrada { get; set; }

            public ICollection<ItemEntrada> ItensEntrada { get; set; } = new List<ItemEntrada>();
            
            public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        
    }
}
