using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int pro_id { get; set; }
        string pro_nome { get; set; }
        int pro_categoria_id { get; set; }
        [ForeignKey("pro_categoria_id")]
        Categoria pro_categoria { get; set; }
    }
}
