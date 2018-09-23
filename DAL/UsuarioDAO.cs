using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAO
    {
        ModelSistema ctx = new ModelSistema();

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public void Incluir(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }

        public Usuario buscarPorCPF(string cpf)
        {
            return ctx.Usuarios.Where(u => u.Usu_cpf == cpf).FirstOrDefault();
        }

        public Usuario buscar(int id)
        {
            return ctx.Usuarios.Where(u => u.Usu_id == id).FirstOrDefault();
        }

        public Usuario editar(Usuario usuario)
        {
            ctx.Entry(usuario).State = EntityState.Modified;
            ctx.SaveChanges();
            return usuario;
        }

        public Boolean remover(int id)
        {
            Usuario usuario = this.buscar(id);

            ctx.Usuarios.Remove(usuario);

            return true;
        }

    }
}
