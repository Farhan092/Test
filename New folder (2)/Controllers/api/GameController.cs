using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers.api
{
    //[RoutePrefix("api/games")]
    public class GamesApiController : ApiController
    {
        private readonly AppDBGame db = new AppDBGame();

        // GET: api/games
        [HttpGet]
        [Route("api/games")]
        public async Task<IHttpActionResult> GetGames()
        {
            var games = await db.Game.ToListAsync();
            return Ok(games);
        }

        // GET: api/games/5
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> GetGame(int id)
        {
            var game = await db.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(game);
        }

        // POST: api/games
        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> CreateGame([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Game.Add(game);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = game.Id }, game);
        }

        // PUT: api/games/5
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> UpdateGame(int id, [FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != game.Id)
            {
                return BadRequest();
            }

            db.Entry(game).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/games/5
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> DeleteGame(int id)
        {
            var game = await db.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            db.Game.Remove(game);
            await db.SaveChangesAsync();

            return Ok(game);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GameExists(int id)
        {
            return db.Game.Count(e => e.Id == id) > 0;
        }
    }
}
