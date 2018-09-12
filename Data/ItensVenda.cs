using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ItensVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int itv_id { get; set; }
        int itv_venda_id { get; set; }
        [ForeignKey("itv_venda_id")]
        Venda itv_venda { get; set; }
        int itv_produto_id { get; set; }
        [ForeignKey("itv_produto_id")]
        Produto itv_produto { get; set; }
        decimal itv_valor_prod { get; set; }
    }
}
