using HSJProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace HSJProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HSJProjectContext _context;

        public ProductsController(HSJProjectContext context)
        {

            _context = context;
        }

        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductCreate()
        {
            return View();
        }
    }
}
