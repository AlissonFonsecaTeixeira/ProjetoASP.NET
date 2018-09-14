using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        public int Ven_id { get; set; }

        public int Ven_usuario_id { get; set; }
        [ForeignKey("Ven_usuario_id")]
        public Usuario Ven_usuario { get; set; }

        public decimal Ven_total { get; set; }
        public DateTime Ven_data { get; set; }

        public ICollection<ItensVenda> ItensDaVenda { get; set; }
    }
}
