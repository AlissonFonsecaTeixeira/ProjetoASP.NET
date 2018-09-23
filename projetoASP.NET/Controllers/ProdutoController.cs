using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetoASP.NET.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutoService produtoService = new ProdutoService();
        CategoriaService categoriaService = new CategoriaService();

        // GET: Produto
        public ActionResult Index()
        {
            IList<Produto> produtos = produtoService.Listar();
            return View(produtos);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View(produtoService.buscar(id));
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            Produto produto = new Produto();

            List<Categoria> categorias = categoriaService.Listar();

            SelectList list = new SelectList(categorias, "Cat_id", "Cat_nome", 1);

            ViewBag.categorias = list;

            return View(produto);
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Produto produto = new Produto();

            produto.Pro_categoria_id = Convert.ToInt32(collection["Pro_categoria_id"]);
            produto.Pro_nome = collection["Pro_nome"];
            produto.Pro_valor = Convert.ToDecimal(collection["Pro_valor"]);

            produtoService.Incluir(produto);

            return RedirectToAction("Index");

        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            List<Categoria> categorias = categoriaService.Listar();

            SelectList list = new SelectList(categorias, "Cat_id", "Cat_nome", 1);

            ViewBag.categorias = list;

            return View(produtoService.buscar(id));
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Produto produto = produtoService.buscar(id);
            try
            {
                // TODO: Add update logic here
                produto.Pro_nome = collection["Pro_nome"];
                produto.Pro_valor = Convert.ToDecimal(collection["Pro_valor"]);
                produto.Pro_categoria_id = Convert.ToInt32(collection["Pro_categoria_id"]);
                produtoService.editar(produto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
