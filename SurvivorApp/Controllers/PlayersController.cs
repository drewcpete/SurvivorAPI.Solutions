using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Survivor.Models;
using Microsoft.EntityFrameworkCore;

namespace Survivor.Controllers
{
    
    public class PlayersController : Controller
    {
      

        public ActionResult Index()
        {
            var allPlayers = Player.GetPlayers();
            return View(allPlayers);
        }

        public ActionResult AddPlayer()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddPlayer(Player player)
        {
            Player.AddNewPlayer(player);
            return RedirectToAction("Index");
        }

    }

}