using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return ctx.Produtos.Include("Pro_Categoria").ToList();
        }

        public void Incluir(Produto produto)
        {
            ctx.Produtos.Add(produto);
            ctx.SaveChanges();
        }

        public Produto buscar(int id)
        {
            return ctx.Produtos.Where(p => p.Pro_id == id).Include("Pro_Categoria").FirstOrDefault();
        }

        public Produto editar(Produto produto)
        {
            ctx.Entry(produto).State = EntityState.Modified;
            ctx.SaveChanges();
            return produto;
        }
    }
}
