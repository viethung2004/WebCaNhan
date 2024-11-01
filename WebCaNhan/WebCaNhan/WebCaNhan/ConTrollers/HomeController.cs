using Microsoft.AspNetCore.Mvc;

namespace WebCaNhan.ConTrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
