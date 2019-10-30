using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Survivor.Models;
using Microsoft.EntityFrameworkCore;

namespace Survivor.Controllers
{
    
    public class PlayersController : Controller
    {
        // private SurvivorContext _db;
        // public PlayersController(SurvivorContext db)
        // {
        //     _db = db;
        // }

        public ActionResult Index()
        {
            var allPlayers = Player.GetPlayers();
            return View(allPlayers);
        }


        // [HttpGet]
        // public ActionResult<IEnumerable<Player>> GetQuery(string playerName, int totalDays)
        // {
        //     var query = _db.Players.AsQueryable();

        //     if (playerName != null)
        //     {
        //         query = query.Where(entry => entry.PlayerName == playerName);
        //     }
        //     if (totalDays != 0)
        //     {
        //         query = query.Where(entry => entry.TotalDays == totalDays);
        //     }
           
        //     return query.ToList();
        // }


        // // Post api/players
        // [HttpPost]
        // public void Post([FromBody] Player player)
        // {
        //     _db.Players.Add(player);
        //     _db.SaveChanges();
        // }

        // //get a specific player by id
        // [HttpGet("id/{id}")]
        // public ActionResult<Player> GetbyID(int id)
        // {
        //     return _db.Players.FirstOrDefault(e => e.PlayerId == id);
        // }
        // //get a specific player by totaldays
        // [HttpGet("totaldays/{totaldays}")]
        // public ActionResult<Player> GetByDay(int totalDays)
        // {
        //     return _db.Players.FirstOrDefault(e => e.TotalDays == totalDays);
        // }
 
        // [HttpGet("playername/{playername}")]
        // public ActionResult<Player> GetByName(string playername)
        // {
        //     return _db.Players.FirstOrDefault(e => e.PlayerName == playername);
        // }


        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] Player player)
        // {
        //     player.PlayerId = id;
        //     _db.Entry(player).State = EntityState.Modified;
        //     _db.SaveChanges();
        // }

        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        //     var playerToDelete = _db.Players.FirstOrDefault(e => e.PlayerId == id);
        //     _db.Players.Remove(playerToDelete);
        //     _db.SaveChanges();
        // }
    }

}