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
using cmrModelo;
using cmrService;
using cmrServiceImpl;

namespace RestMusisot.Controllers
{
    public class LoginUsuariosController : ApiController
    {
        //private CrmTributariaEntities db = new CrmTributariaEntities();

        LoginUsuarioService loginUsuarioServiceImpl;

        public LoginUsuariosController()
        {
            loginUsuarioServiceImpl = new LoginUsuarioImpl();
        }

        // GET: api/LoginUsuarios/5
        [ResponseType(typeof(LoginUsuario))]
        public IHttpActionResult GetLoginUsuario(long id)
        {
            LoginUsuario loginUsuario = loginUsuarioServiceImpl.validarLogin(id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            return Ok(loginUsuario);
        }

        /**
        // GET: api/LoginUsuarios
        public IQueryable<LoginUsuario> GetLoginUsuario()
        {
            return db.LoginUsuario;
        }

        // PUT: api/LoginUsuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLoginUsuario(long id, LoginUsuario loginUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != loginUsuario.idPersona)
            {
                return BadRequest();
            }

            db.Entry(loginUsuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginUsuarioExists(id))
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

        // POST: api/LoginUsuarios
        [ResponseType(typeof(LoginUsuario))]
        public IHttpActionResult PostLoginUsuario(LoginUsuario loginUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LoginUsuario.Add(loginUsuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LoginUsuarioExists(loginUsuario.idPersona))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = loginUsuario.idPersona }, loginUsuario);
        }

        // DELETE: api/LoginUsuarios/5
        [ResponseType(typeof(LoginUsuario))]
        public IHttpActionResult DeleteLoginUsuario(long id)
        {
            LoginUsuario loginUsuario = db.LoginUsuario.Find(id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            db.LoginUsuario.Remove(loginUsuario);
            db.SaveChanges();

            return Ok(loginUsuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoginUsuarioExists(long id)
        {
            return db.LoginUsuario.Count(e => e.idPersona == id) > 0;
        }
    */
    }
}