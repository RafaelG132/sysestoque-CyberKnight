using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    public class Produto {


        [Key]
        public int? id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string estoque { get; set; }

        public double precoUnit { get; set; }
        
        public float estoqueMax { get; set; }
        public float estoqueMedio { get; set; }
        
        //public float estoqueMin { get; set; }

        [ForeignKey(nameof(categoria))]
        public int CategoriaId { get; set; } 
        public Categoria? categoria { get; set; }


        [ForeignKey(nameof(UnidadeMedida))]
        public int? UnidadeMedidaId { get; set; }
        public UnidadeMedida? UnidadeMedida { get; set; }

        public ICollection<NotaEntrada>? NotasEntrada { get; set; } = new List<NotaEntrada>();

        public ICollection<ItemEntrada>? ItensEntrada { get; set; } = new List<ItemEntrada>();

        public ICollection<NotaSaida>? NotasSaida { get; set; } = new List<NotaSaida>();

        public ICollection<ItemSaida>? ItensSaida { get; set; } = new List<ItemSaida>();

        public ICollection<Fornecedor>? Fornecedores { get; set; } = new List<Fornecedor>();

    }
}