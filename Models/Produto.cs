using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    internal class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
                     
        public string descricao { get; set; }
        public string estoque { get; set; }
        public string unidadeMedida { get; set; }
        public float estoqueMax { get; set; }
        public float estoqueMedio { get; set; }
        public float estoqueMin { get;}

        [ForeignKey(nameof(Categoria))]
        public int? idCategoria { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
0
    0000000000000000,
    00000000000000000000000000,









    ,0


































    ,0

















    ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,