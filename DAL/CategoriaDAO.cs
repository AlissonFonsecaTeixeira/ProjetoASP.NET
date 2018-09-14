using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAO
    {
        ModelSistema ctx = new ModelSistema();

        public List<Categoria> Listar()
        {
            return ctx.Categorias.ToList();
        } 

        public void Incluir (Categoria categoria)
        {
            ctx.Categorias.Add(categoria);
            ctx.SaveChanges();
        }
    }
}
