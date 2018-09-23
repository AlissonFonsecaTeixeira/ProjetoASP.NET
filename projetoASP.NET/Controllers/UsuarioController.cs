using BLL;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetoASP.NET.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioService usuarioService = new UsuarioService();

        // GET: Usuario
        public ActionResult Index()
        {
            IList<Usuario> usuarios = usuarioService.Listar();
            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            Usuario usuario = usuarioService.buscar(id);
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario.Usu_login = collection["Usu_login"];
                usuario.Usu_cpf = collection["Usu_cpf"];
                usuario.Usu_senha = collection["Usu_senha"];

                usuarioService.Incluir(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(usuario);
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            Usuario usuario = usuarioService.buscar(id);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Usuario usuario = usuarioService.buscar(id);
            try
            {
                usuario.Usu_login = collection["Usu_login"];
                usuario.Usu_cpf = collection["Usu_cpf"];
                usuario.Usu_senha = collection["Usu_senha"];

                usuarioService.editar(usuario);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(usuario);
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
