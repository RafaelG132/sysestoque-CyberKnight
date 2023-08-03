using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    internal class ItemSaida{
        [Key]
        public int notasaida { get; set; }

        public int Produto { get; set; }

        public int Qtd { get; set; }

    }
}
