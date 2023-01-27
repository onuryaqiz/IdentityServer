using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controller
{
    public class AdminController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
