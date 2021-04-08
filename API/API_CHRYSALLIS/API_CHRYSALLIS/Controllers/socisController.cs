using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using API_CHRYSALLIS.Models;

namespace API_CHRYSALLIS.Controllers
{
    public class socisController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        // GET: api/socis
        public IQueryable<socis> Getsocis()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.socis;
        }

        // GET: api/socis/5
        [ResponseType(typeof(socis))]
        public async Task<IHttpActionResult> Getsocis(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            socis socis = await db.socis.FindAsync(id);
            if (socis == null)
            {
                return NotFound();
            }

            return Ok(socis);
        }
        [HttpGet]
        [Route("api/socis/email/{email}")]
        public async Task<IHttpActionResult> FoundByEmail(String email)
        {
            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            socis _soci = await db.socis.Include("comunitats").Where(s => s.email.Equals(email)).FirstOrDefaultAsync();

            return Ok(_soci);
        }

        // PUT: api/socis/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putsocis(int id, socis socis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != socis.id)
            {
                return BadRequest();
            }

            db.Entry(socis).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!socisExists(id))
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

        // POST: api/socis
        [ResponseType(typeof(socis))]
        public async Task<IHttpActionResult> Postsocis(socis socis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.socis.Add(socis);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = socis.id }, socis);
        }

        // DELETE: api/socis/5
        [ResponseType(typeof(socis))]
        public async Task<IHttpActionResult> Deletesocis(int id)
        {
            socis socis = await db.socis.FindAsync(id);
            if (socis == null)
            {
                return NotFound();
            }

            db.socis.Remove(socis);
            await db.SaveChangesAsync();

            return Ok(socis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool socisExists(int id)
        {
            return db.socis.Count(e => e.id == id) > 0;
        }
    }
}