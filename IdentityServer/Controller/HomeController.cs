using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
