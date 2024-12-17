using Microsoft.AspNetCore.Mvc;

namespace HSJProject.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
