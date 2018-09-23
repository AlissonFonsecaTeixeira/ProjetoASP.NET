using DAL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaService
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        public List<Categoria> Listar()
        {
            return categoriaDAO.Listar();
        }

        public void Incluir(Categoria categoria)
        {
            categoriaDAO.Incluir(categoria);
        }

        public Categoria buscar (int id)
        {
            return categoriaDAO.buscar(id);
        }

        public Categoria editar (Categoria categoria)
        {
            return categoriaDAO.editar(categoria);
        }

        public Boolean remover(int id)
        {
            return categoriaDAO.remover(id);
        }
    }
}
