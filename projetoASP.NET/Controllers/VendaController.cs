using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetoASP.NET.Controllers
{
    public class VendaController : Controller
    {
        ProdutoService produtoService = new ProdutoService();
        VendaService vendaService = new VendaService();

        // GET: Venda
        public ActionResult Index()
        {
            return View(vendaService.Listar());
        }

        /**
         * Lista os filmes disponiveis para serem alugados
         */
        public ActionResult RegistrarVenda()
        {

            return View(produtoService.Listar());
        }

        [HttpPost]
        public ActionResult RegistrarVenda(FormCollection collection)
        {
            Venda venda = new Venda();

            venda.Ven_data = DateTime.Now;
            venda.Ven_usuario_id = Convert.ToInt32(collection["Usu_id"]);
            venda.Ven_total = 0;

            string myList = Request.Form["produto[]"];
            if (string.IsNullOrEmpty(myList))
            {
                Response.Write("Favor Selecionar algum produto !");
                return RedirectToAction("Index");
            }
            foreach (string Item in myList.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                int id = Convert.ToInt32(Item);
                Produto produto = produtoService.buscar(id);
                venda.Ven_total = venda.Ven_total + produto.Pro_valor;
            }

                vendaService.Incluir(venda);

            return RedirectToAction("Index");

        }
    }
}