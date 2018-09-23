using DAL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VendaService
    {
        VendaDAO vendaDAO = new VendaDAO();

        public IList<Venda> Listar()
        {
            return vendaDAO.Listar();
        }

        public void Incluir(Venda venda)
        {
            vendaDAO.Incluir(venda);
        }

        public Venda buscar(int id)
        {
            return vendaDAO.buscar(id);
        }

        public Venda editar(Venda venda)
        {
            return vendaDAO.editar(venda);
        }

    }
}
