using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_CyberKnight.Models
{
    internal class NotaSaida{
        [Key]
        public int id { get; set; }

        public DateTime dataentrada { get; set; }

        public float valortotal { get; set; }

        public ICollection<NotaSaida> ItemSaida { get; set; }
    }
}
