using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetoASP.NET.Controllers
{
    public class CategoriaController : Controller
    {
        CategoriaService categoriaService = new CategoriaService();

        // GET: Categoria
        public ActionResult Index()
        {
            IList<Categoria> categorias = categoriaService.Listar();
            return View(categorias);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Categoria categoria = new Categoria();
            try
            {
                categoria.Cat_nome = collection["Cat_nome"];
                categoria.Cat_descricao = collection["Cat_descricao"];

                categoriaService.Incluir(categoria);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(categoria);
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id, FormCollection collection)
        {
            Categoria categoria = categoriaService.buscar(id);
            
            return View(categoria);
            
        }

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            categoriaService.editar(categoria);
            return RedirectToAction("Index");
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categoria/Delete/5
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
