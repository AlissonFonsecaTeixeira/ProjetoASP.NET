using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("ItensVenda")]
    public class ItensVenda
    {
        [Key]
        public int Itv_id { get; set; }

        public int Itv_venda_id { get; set; }
        [ForeignKey("Itv_venda_id")]
        Venda Itv_venda { get; set; }

        public int Itv_produto_id { get; set; }
        [ForeignKey("Itv_produto_id")]
        Produto Itv_produto { get; set; }

        public decimal Itv_valor_prod { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
