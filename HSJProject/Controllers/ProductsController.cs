using HSJProject.Data;
using HSJProject.DataModels;
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

        public IActionResult Furnitures()
        {
            var ProductList = _context.Products.ToList();

            return View(ProductList);
        }
        public IActionResult ProductList()
        {
            var ProductList = _context.Products.ToList();

            return View(ProductList);
        }
        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductCreate(Product ProductData)
        {
            try
            {
                if (ProductData != null && ProductData.ProductName !=null) {
                    _context.Add(ProductData);
                    _context.SaveChanges();
                }
               
            }
            catch (Exception ex)
            {
                return NotFound();
            }


            return View(ProductData);
        }
    }
}
