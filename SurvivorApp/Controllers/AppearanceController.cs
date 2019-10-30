// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Survivor.Models;
// using Microsoft.EntityFrameworkCore;

// namespace Survivor.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class AppearanceController : Controller
//     {
//         private SurvivorContext _db;
//         public AppearanceController(SurvivorContext db)
//         {
//             _db = db;
//         }


//         //api/appearance
//         [HttpPost] 
//         public void Post([FromBody] Appearance appearance)
//         {
//             _db.Appearances.Add(appearance);
//             _db.SaveChanges();
//         }
//     }
// }