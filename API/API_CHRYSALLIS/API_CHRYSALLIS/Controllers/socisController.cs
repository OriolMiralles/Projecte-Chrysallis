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
        [Route("api/socis/email/{email}/")]
        public async Task<IHttpActionResult> FoundByEmail(String email)
        {
            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            socis _soci = await db.socis.Include("comunitats").Include("assistir").Where(s => s.email.Equals(email)).FirstOrDefaultAsync();

            return Ok(_soci);
        }

        // PUT: api/socis/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putsocis(int id, socis socis)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                String missatge = "";
                if (id != socis.id)
                {
                    result = BadRequest(missatge);
                }
                else
                {

                    db.Entry(socis).State = EntityState.Modified;
                    result = StatusCode(HttpStatusCode.NoContent);
                    try
                    {
                        await db.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!socisExists(id))
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

            }



            return result;
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


        [HttpPost]
        [Route("api/socis/comunitats/{id}")]
        public async Task<IHttpActionResult> InsertComunitats(int id, comunitats comunitat)
        {
            db.Configuration.LazyLoadingEnabled = false;
            socis soci = await db.socis.FindAsync(id);
            comunitats com = await db.comunitats.FindAsync(comunitat.id);
            soci.comunitats.Add(com);
            await db.SaveChangesAsync();


            return Ok(soci);
        }
        [HttpPost]
        [Route("api/socis/esdeveniment/{id}")]
        public async Task<IHttpActionResult> InsertEsdeveniment(int id, esdeveniments esdeveniment)
        {
            db.Configuration.LazyLoadingEnabled = false;
            socis soci = await db.socis.FindAsync(id);
            esdeveniments _esdev = await db.esdeveniments.FindAsync(esdeveniment.id);
            soci.esdeveniments.Add(_esdev);
            await db.SaveChangesAsync();


            return Ok(soci);
        }

        [HttpPut]
        [Route("api/socis/comunitats/{id}")]
        public async Task<IHttpActionResult> updateComunitats(int id, socis _soci)
        {
            IHttpActionResult result;
            String missatge = "";

            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }

            if (id != _soci.id)
            {
                result = BadRequest();
            }
            socis dbSocis = db.socis
                .Include(s => s.comunitats)
                .Where(s => s.id == id)
                .First();
            comunitats com = db.comunitats.Where(c => c.id == _soci.comunitats.ElementAt(0).id).First();
            //Modifica los datos que no son objetos
            db.Entry(dbSocis).CurrentValues.SetValues(_soci);

            dbSocis.comunitats.Clear();

            dbSocis.comunitats.Add(com);
            

            try
            {
                await db.SaveChangesAsync();
                result = StatusCode(HttpStatusCode.NoContent);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!socisExists(id))
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

            return result;

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