using DAL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProdutoService
    {
        ProdutoDAO produtoDAO = new ProdutoDAO();

        public IList<Produto> Listar()
        {
            return produtoDAO.Listar();
        }
    }
}
