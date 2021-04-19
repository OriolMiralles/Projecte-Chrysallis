using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using API_CHRYSALLIS.Models;

namespace API_CHRYSALLIS.Controllers
{
    public class assistirsController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        // GET: api/assistirs
        public IQueryable<assistir> Getassistir()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.assistir;
        }

        // GET: api/assistirs/5
        [ResponseType(typeof(assistir))]
        public async Task<IHttpActionResult> Getassistir(int id)
        {
            assistir assistir = await db.assistir.FindAsync(id);
            if (assistir == null)
            {
                return NotFound();
            }

            return Ok(assistir);
        }

        [HttpGet]
        [Route("api/assistir/soci/{id}")]
        public async Task<IHttpActionResult> FoundById(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<assistir> assistir = db.assistir.Include("esdeveniments").Where(a => a.socis.id==id).ToList();

            return Ok(assistir);
        }

        // PUT: api/assistirs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putassistir(int id, assistir assistir)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != assistir.id_soci)
                {
                    result = BadRequest();
                }

                db.Entry(assistir).State = EntityState.Modified;
                result = StatusCode(HttpStatusCode.NoContent);

                try
                {
                    await db.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!assistirExists(id))
                    {
                        result = NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = CLASES.Utilitat.missatgeError(sqlException);
                    result = BadRequest(missatge);
                }

            }



            return result;
        }


        // POST: api/assistirs
        [ResponseType(typeof(assistir))]
        public async Task<IHttpActionResult> Postassistir(assistir assistir)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(missatge);
            }
            else
            {
                db.assistir.Add(assistir);
                result = CreatedAtRoute("DefaultApi", new { id = assistir.id_soci }, assistir);
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (assistirExists(assistir.id_soci))
                    {
                        result = Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = CLASES.Utilitat.missatgeError(sqlException);
                    result = BadRequest(missatge);
                }
            }



            return result;
        }

        // DELETE: api/assistirs/5
        [ResponseType(typeof(assistir))]
        public async Task<IHttpActionResult> Deleteassistir(int id)
        {
            assistir assistir = await db.assistir.FindAsync(id);
            if (assistir == null)
            {
                return NotFound();
            }

            db.assistir.Remove(assistir);
            await db.SaveChangesAsync();

            return Ok(assistir);
        }
        [HttpDelete]
        [Route("api/assistirs/{id_soci}/{id_esdeveniment}/")]
        public async Task<IHttpActionResult> DeleteAssistirUser(int id_soci, int id_esdeveniment)
        {
            assistir assistir = await db.assistir.Where(a =>a.id_soci==id_soci &&  a.id_esdeveniment==id_esdeveniment).FirstOrDefaultAsync() ;
            if (assistir == null)
            {
                return NotFound();
            }

            db.assistir.Remove(assistir);
            await db.SaveChangesAsync();

            return Ok(assistir);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool assistirExists(int id)
        {
            return db.assistir.Count(e => e.id_soci == id) > 0;
        }
    }
}