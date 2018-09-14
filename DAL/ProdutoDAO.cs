using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAO
    {
        ModelSistema ctx = new ModelSistema();

        public List<Produto> Listar()
        {
            return ctx.Produtos.ToList();
        }
    }
}
