using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Categoria buscar (int id)
        {
            return ctx.Categorias.Where(c => c.Cat_id == id).FirstOrDefault();
        }

        public Categoria editar (Categoria categoria)
        {
            ctx.Entry(categoria).State = EntityState.Modified;
            //ctx.Categorias.Add(categoria);
            ctx.SaveChanges();
            return categoria;
        }

        public Boolean remover(int id)
        {
            Categoria categoria= this.buscar(id);

            ctx.Categorias.Remove(categoria);

            return true;
        }
    }
}
