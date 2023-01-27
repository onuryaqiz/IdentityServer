using Microsoft.AspNetCore.Mvc;

namespace Identity_Server.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
