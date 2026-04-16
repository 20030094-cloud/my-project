
using Microsoft.AspNetCore.Mvc;

namespace sanhya.Controllers
{
    public class studentController : Controller
    {
        // Exercise 2
        public IActionResult Index()
        {
            return View();
        }

        // Exercise 4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}