using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BLL;
using Data;

namespace projetoASP.NET.Controllers
{
    public class UsuarioApiController : ApiController
    {
        UsuarioService usuarioService = new UsuarioService();

        // GET: api/Usuario
        public IList<Usuario> GetUsuarios()
        {
            return usuarioService.Listar();
        }

        // GET: api/Usuario/5
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult GetUsuario(int id)
        {
            Usuario usuario = usuarioService.buscar(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // PUT: api/Usuario/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsuario(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.Usu_id)
            {
                return BadRequest();
            }

            try
            {
                usuario.Usu_id = id;
                usuarioService.editar(usuario);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Usuario
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult PostUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            usuarioService.Incluir(usuario);

            return CreatedAtRoute("DefaultApi", new { id = usuario.Usu_id }, usuario);
        }

        // DELETE: api/Usuario/5
        [ResponseType(typeof(Usuario))]
        public IHttpActionResult DeleteUsuario(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return Ok(usuarioService.remover(id));
        }


        private bool UsuarioExists(int id)
        {
            Usuario usuario = usuarioService.buscar(id);

            return usuario.Usu_id != null;
        }
    }
}