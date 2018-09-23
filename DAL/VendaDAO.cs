using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendaDAO
    {
        ModelSistema ctx = new ModelSistema();

        public List<Venda> Listar()
        {
            return ctx.Vendas.Include("Ven_usuario").ToList();
        }

        public void Incluir(Venda venda)
        {
            ctx.Vendas.Add(venda);
            ctx.SaveChanges();
        }

        public Venda buscar(int id)
        {
            return ctx.Vendas.Where(v => v.Ven_id == id).FirstOrDefault();
        }

        public Venda editar(Venda venda)
        {
            ctx.Entry(venda).State = EntityState.Modified;
            ctx.SaveChanges();
            return venda;
        }
    }
}
