using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Pro_id { get; set; }

        public string Pro_nome { get; set; }
        [DataType(DataType.Currency)]
        public decimal Pro_valor { get; set; }

        public int Pro_categoria_id { get; set; }
        [ForeignKey("Pro_categoria_id")]
        public Categoria Pro_categoria { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
    }
}
