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

        public void Incluir(Produto produto)
        {
            produtoDAO.Incluir(produto);
        }

        public Produto buscar(int id)
        {
            return produtoDAO.buscar(id);
        }

        public Produto editar(Produto produto)
        {
            return produtoDAO.editar(produto);
        }

    }
}
