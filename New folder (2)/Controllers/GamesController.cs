using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers.api
{
    public class GamesController : Controller
    {
        private AppDBGame db = new AppDBGame();

        // GET: Games
        public ActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://localhost:55347/api/games"); // http://..api/game
                var response = client.GetAsync("games"); // route name inside it; last address: games (example)
                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    var data = response.Result.Content.ReadAsAsync<IEnumerable<Game>>().Result;
                    return View(data);

                }
                else
                    return HttpNotFound();
            }

            //return View(db.Game.ToList());
        }

        // GET: Games/Details/5
        public ActionResult Details(int? id)
        {
            /*if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);*/

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://..api/games");
                var response = client.GetAsync("games/" + id.ToString());


                if (response.Result.IsSuccessStatusCode)
                {
                    var data = response.Result.Content.ReadAsAsync<IEnumerable<Game>>().Result;
                    return View(data);

                }
                return HttpNotFound();
            }

        }

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Game game)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://..api/addgames");
                var response = client.PostAsJsonAsync("addgames", game);
                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    return RedirectToAction("index");


                }
                else
                {
                    return HttpNotFound();
                }

            }
        }






        /*public ActionResult Create([Bind(Include = "Id,Name,Description,Price")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Game.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }*/

        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://..api/updategames");
                var response = client.PutAsJsonAsync("updategames/" + game.Id.ToString(), game);
                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    return HttpNotFound();
                }

            }








            /* if (ModelState.IsValid)
             {
                 db.Entry(game).State = EntityState.Modified;
                 db.SaveChanges();
                 return RedirectToAction("Index");
             }
             return View(game);*/
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Game.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /*Game game = db.Game.Find(id);
            db.Game.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");*/



            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://..api/deletegames");
                var response = client.DeleteAsync("deletegames/" + id.ToString());
                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    return HttpNotFound();
                }

            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
