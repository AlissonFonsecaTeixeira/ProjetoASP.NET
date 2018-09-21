using DAL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioService
    {
        UsuarioDAO usuarioDAO= new UsuarioDAO();

        public IList<Usuario> Listar()
        {
            return usuarioDAO.Listar();
        }

        public void Incluir(Usuario usuario)
        {
            usuarioDAO.Incluir(usuario);
        }

        public Usuario buscar(int id)
        {
            return usuarioDAO.buscar(id);
        }

        public Usuario editar(Usuario usuario)
        {
            return usuarioDAO.editar(usuario);
        }

        public Boolean remover (int id)
        {
            return usuarioDAO.remover(id);
        }
    }
}
