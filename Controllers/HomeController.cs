using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        private MusicStoreDB storeDB = new MusicStoreDB();

        public ActionResult Index()
        {
            ViewBag.Message = "I like cake!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Edit()
        {        
            return View();
        }

        public ActionResult Sample()
        {
            ViewBag.Message = "Hello World. Welcome to ASP.NET MVC!";
            return View("Sample");
        }

        public ActionResult Search(string q)
        {
            var albums = storeDB.Albums
                                .Include("Artist")
                                .Where(a => a.Title.Contains(q))
                                .Take(10);
            return View(albums);
        }

        
    }
}
