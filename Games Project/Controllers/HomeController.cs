using Games_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Games_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var videoGames = VideoGameManager.GetVideoGames();
            return View(videoGames);
        }
        public ActionResult Detail(int id)
        {
            var videoGames = VideoGameManager.GetVideoGames();
            var videoGame = videoGames.FirstOrDefault(p => p.VideoGameID == id);
            return View(videoGame);
        }
    }
}