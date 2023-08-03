using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sysestoque_CyberKnight.Models
{
    internal class NotaEntrada{
        [Key]                                                                                                                                                                                                                                         
            public DateTime DataEntrada { get; set; }

            public float ValorTotal { get; set; }

            public Fornecedor fornecedor { get; set; } = new Fornecedor();

            public Produto produtos { get; set; }

            public Usuario ResponsavelEntrada { get; set; }

            public ICollection<NotaEntrada> ItemEntrada { get; set; } = new List<NotaEntrada>();

        
    }
}
