using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    internal class ItemEntrada{
        [Key]
            public NotaEntrada notaEntrada { get; set; }
            public Produto produto { get; set; }
            public int Qtd { get; set; }
        
    }
}
