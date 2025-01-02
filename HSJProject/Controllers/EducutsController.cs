using HSJProject.Data;
using HSJProject.DataModels;
using HSJProject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HSJProject.Controllers
{
    public class EducutsController : Controller
    {
        private readonly HSJProjectContext _context;

        public EducutsController(HSJProjectContext context)
        {

            _context = context;
        }

        public IActionResult Home()
        {
            ViewBag.Slider = new
            {
                Slider1 = "Why do we use it",
                SliderBody1 = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                Slider2 = "Where can I get some",
                SliderBody2 = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form",
                Slider3 = "Where does it come from",
                SliderBody3 = "Contrary to popular belief, Lorem Ipsum is not simply random text."
            };


            ViewBag.Furniture = new
            {
                Title = "Our Furniture",
                Content = "which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't an"
            };


            ViewBag.AboutUs = "The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.";


            //viewmodel

            var AllData = new HomePageVM();

            AllData.Blogs = _context.Blog.Take(3).ToList();
            AllData.Products = _context.Products.Where(obj => obj.IsActive == true && obj.ProductStock > 0).Take(3).ToList();


            return View(AllData);
        }


        public IActionResult Contactus()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ContactSubmit(Contact datamodel)
        {

            if (datamodel.PhoneNumber != null && datamodel.Name !=null && datamodel.Email !=null)
            {
                _context.Add(datamodel);
                _context.SaveChanges();
               
            }


            return RedirectToAction("Contactus");
        }


      
        public IActionResult ContactList()
        {
            //SELECT * FROM Contact
            var data = _context.Contact.ToList();

            return View(data);
        }
        
        public IActionResult ContactEdit(int? id)
        {
            if (id == null)
                return NotFound();

            //select * from Contact where  Id = 2
            var contact = _context.Contact.FirstOrDefault(akash => akash.Id == id);
           
            return View(contact);
        }

        [HttpPost]
        public IActionResult ContactEdit(Contact datamodel)
        {

            if (datamodel.PhoneNumber != null && datamodel.Name != null && datamodel.Email != null)
            {
                _context.Update(datamodel);
                _context.SaveChanges();
            }

            return RedirectToAction("ContactList");
        }

        public IActionResult ContactDelete(int? id)
        {
            if (id == null)
                return NotFound();

            //select * from Contact where  Id = 2
            var contact = _context.Contact.FirstOrDefault(akash => akash.Id == id);
            if(contact == null)
                return NotFound();

            _context.Remove(contact);
            _context.SaveChanges();

            return RedirectToAction("ContactList");
        }

    }
}
