using Microsoft.AspNetCore.Mvc;

namespace sanhya.Controllers
{
    public class MyIDController : Controller
    {
        public IActionResult DescribeMySelf()
        {
            return View();
        }
    }
}