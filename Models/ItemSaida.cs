using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sysestoque_CyberKnight.Models.Config;

namespace sysestoque_CyberKnight.Models{
    [EntityTypeConfiguration(typeof(ItemNotaSaidaConfig))]
    public class ItemSaida{

        [ForeignKey(nameof(NotaSaida))]
        public int NotaSaidaId { get; set; }
        public NotaSaida? NotaSaida { get; set; }


        [ForeignKey(nameof(Produto))]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public int Qtd { get; set; }

    }
}
