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
    public class esdevenimentsController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        // GET: api/esdeveniments
        public IQueryable<esdeveniments> Getesdeveniments()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.esdeveniments;
        }

        // GET: api/esdeveniments/5
        [ResponseType(typeof(esdeveniments))]
        public async Task<IHttpActionResult> Getesdeveniments(int id)
        {
            esdeveniments esdeveniments = await db.esdeveniments.FindAsync(id);
            if (esdeveniments == null)
            {
                return NotFound();
            }

            return Ok(esdeveniments);
        }
        [HttpGet]
        [Route("api/esdeveniments/comunitat/{id}/")]
        public async Task<IHttpActionResult> FoundByIdComunitat(int id)
        {
          
            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<esdeveniments> _esdeveniments = db.esdeveniments.
                Include("comunitats").Include("localitats").Where(e => e.id_comunitat==id && e.data > DateTime.Now)
                .OrderBy(e => e.data).ToList();

            return Ok(_esdeveniments);
        }

        [HttpGet]
        [Route("api/esdeveniments/eventoNoRealizado/{id}/")]
        public async Task<IHttpActionResult> FoundByEventoNoRealizado(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<esdeveniments> _esdeveniments = db.esdeveniments.
                Include("comunitats").Include("localitats").Include("assistir")
                .Where(e => e.assistir.Any(a => a.id_soci == id) && e.data >= DateTime.Now).ToList();

            return Ok(_esdeveniments);
        }

        [HttpGet]
        [Route("api/esdeveniments/eventoRealizado/{id}/")]
        public async Task<IHttpActionResult> FoundByEventoRealizado(int id)
        {

            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<esdeveniments> _esdeveniments = db.esdeveniments.
                Include("comunitats").Include("localitats").Include("assistir")
                .Where(e => e.assistir.Any(a => a.id_soci == id) && e.data < DateTime.Now).ToList();

            return Ok(_esdeveniments);
        }

        [HttpGet]
        [Route("api/esdeveniments/comunitat/{nomComunitat}/{nomCiutat}/{idTipo}/{dateMin}/{dateMax}")]
        public async Task<IHttpActionResult> FoundByIdFiltres(String nomComunitat, String nomCiutat, int idTipo, DateTime dateMin, DateTime dateMax)
        {

            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<esdeveniments> _esdeveniments = db.esdeveniments.
                Include("comunitats").Include("localitats").Where(e => e.comunitats.nom.Equals(nomComunitat) && e.data > dateMin
                                                            && e.data < dateMax && e.id_tipus == idTipo
                                                            && e.localitats.nom.Contains(nomCiutat))
                .OrderBy(e => e.data).ToList();

            return Ok(_esdeveniments);
        }

        [HttpGet]
        [Route("api/esdeveniments/soci/{id}")]
        public async Task<IHttpActionResult> FoundByIdSoci(int id)
        {

            db.Configuration.LazyLoadingEnabled = false;
            IHttpActionResult result;

            List<esdeveniments> _esdeveniments = db.esdeveniments.
                Include("comunitats").Include("localitats").Include("assistir")
                .Where(e => e.assistir.Any(a => a.id_soci == id)).ToList();

            return Ok(_esdeveniments);
        }


        // PUT: api/esdeveniments/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putesdeveniments(int id, esdeveniments esdeveniments)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                String missatge = "";
                if (id != esdeveniments.id)
                {
                    result = BadRequest(missatge);
                }
                else
                {
                    db.Entry(esdeveniments).State = EntityState.Modified;

                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!esdevenimentsExists(id))
                        {
                            return NotFound();
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

        // POST: api/esdeveniments
        [ResponseType(typeof(esdeveniments))]
        public async Task<IHttpActionResult> Postesdeveniments(esdeveniments esdeveniments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.esdeveniments.Add(esdeveniments);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = esdeveniments.id }, esdeveniments);
        }

        // DELETE: api/esdeveniments/5
        [ResponseType(typeof(esdeveniments))]
        public async Task<IHttpActionResult> Deleteesdeveniments(int id)
        {
            esdeveniments esdeveniments = await db.esdeveniments.FindAsync(id);
            if (esdeveniments == null)
            {
                return NotFound();
            }

            db.esdeveniments.Remove(esdeveniments);
            await db.SaveChangesAsync();

            return Ok(esdeveniments);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool esdevenimentsExists(int id)
        {
            return db.esdeveniments.Count(e => e.id == id) > 0;
        }
    }
}