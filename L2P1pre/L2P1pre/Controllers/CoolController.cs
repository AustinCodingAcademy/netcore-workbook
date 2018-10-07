using Microsoft.AspNetCore.Mvc;
using L2P1pre.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L2P1pre.Controllers
{
    public class CoolView : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}