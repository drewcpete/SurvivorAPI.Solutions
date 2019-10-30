using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Survivor.Models;
using Microsoft.EntityFrameworkCore;

namespace Survivor.Controllers
{
   
    public class SeasonsController : Controller
    {
        // private SurvivorContext _db;
        // public SeasonsController(SurvivorContext db)
        // {
        //     _db = db;
        // }

        public ActionResult Index()
        {
            var allSeasons = Season.GetSeasons();
            return View(allSeasons);
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<Season>> Get(string seasonName, int seasonId)
        // {
        //     var query = _db.Seasons.AsQueryable();

        //     if (seasonName != null)
        //     {
        //         query = query.Where(entry => entry.SeasonName == seasonName);
        //     }
        //     if (seasonId != 0)
        //     {
        //         query = query.Where(entry => entry.SeasonId == seasonId);
        //     }
        //     return query.ToList();
        // }
        //  [HttpGet("id/{id}")]
        // public ActionResult<Season> GetbyID(int id)
        // {
        //     return _db.Seasons.FirstOrDefault(e => e.SeasonId == id);
        // }

        // [HttpPost]
        // public void Post([FromBody] Season season)
        // {
        //     _db.Seasons.Add(season);
        //     _db.SaveChanges();
        // }

    }
}