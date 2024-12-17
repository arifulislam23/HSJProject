using Microsoft.AspNetCore.Mvc;

namespace HSJProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
