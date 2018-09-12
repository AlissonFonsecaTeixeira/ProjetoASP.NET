using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int ven_id { get; set; }
        int ven_usuario_id { get; set; }
        [ForeignKey("ven_usuario_id")]
        Usuario ven_usuario { get; set; }
        decimal ven_total { get; set; }
        DateTime ven_data { get; set; }
    }
}
