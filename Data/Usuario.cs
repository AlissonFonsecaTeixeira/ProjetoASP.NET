using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Usu_id { get; set; }
        public string Usu_login { get; set; }
        public string Usu_senha { get; set; }
    }
}
