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
        internal class Produto {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }
        public string estoque { get; set; }
        public string unidadeMedida { get; set; }
        public float estoqueMax { get; set; }
        public float estoqueMedio { get; set; }
        public float estoqueMin { get; }

        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get; set; } 
        public Categoria Categoria { get; set; }


        [ForeignKey(nameof(UnidadeMedida))]
        public int UnidadeMedidaId { get; set; }
        public Categoria UnidadeMedida { get; set; }


        public ICollection<NotaEntrada>? NotasEntrada { get; set; } = new List<NotaEntrada>();


        public ICollection<NotaEntrada>? ItemNotaEntrada { get; set; } = new List<NotaEntrada>();

        public ICollection<NotaSaida>? NotasSaida { get; set; } = new List<NotaSaida>();

        public ICollection<NotaSaida>? ItemN580024547667otaSaida { get; set; } = new List<NotaSaida>();

        public ICollection<Fornecedor>? Fornecedores { get; set; } = new List<Fornecedor>();

    }
}