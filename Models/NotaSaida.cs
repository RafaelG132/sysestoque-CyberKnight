using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models{
    [EntityTypeConfiguration(typeof(NotaSaidaConfig))]
    public class NotaSaida{
        [Key]
        public int Id { get; set; }

        public DateTime DataEntrada { get; set; }

        public float ValorTotal { get; set; }

        public ICollection<ItemSaida> ItensSaida { get; set; } = new List<ItemSaida>();
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
   
    }
}
