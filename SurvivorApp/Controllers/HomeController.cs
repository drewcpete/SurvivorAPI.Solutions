using Microsoft.AspNetCore.Mvc;
using Survivor.Models;

namespace Survivor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
       
            return View();
        }
    }
}