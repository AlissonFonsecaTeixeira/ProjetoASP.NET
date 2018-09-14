using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Cat_id { get; set; }
        public string Cat_nome { get; set; }
        public string Cat_descricao { get; set; }
    }
}
