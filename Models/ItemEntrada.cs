using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using sysestoque_CyberKnight.Models.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models{
    [EntityTypeConfiguration(typeof(ItemNotaEntradaConfig))]
    public class ItemEntrada{

        [ForeignKey(nameof(NotaEntrada))]
        public int NotaEntradaId { get; set; }
        public NotaEntrada? NotaEntrada { get; set; }

        [ForeignKey(nameof(Produto))]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        
        public int Qtd { get; set; }
        
    }
}
