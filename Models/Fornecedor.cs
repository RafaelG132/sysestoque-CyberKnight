using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sysestoque_CyberKnight.Models
{
    public class Fornecedor{
        [Key]
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string RazaoSocial { get; set; }
        public string Responsavel { get; set; }

        public List<Produto> produtos { get; set; } = new List<Produto>();

        public List<NotaEntrada> NFs { get; set; } = new List<NotaEntrada>();
    }
}
