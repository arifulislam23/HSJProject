using HSJProject.Data;
using HSJProject.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace HSJProject.Controllers
{
    public class SocialLinksController : Controller
    {
        private readonly HSJProjectContext _context;

        public SocialLinksController(HSJProjectContext context)
        {

            _context = context;
        }
        public IActionResult SocialNetwork()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveSocialLink(SocialLink socialLink)
        {
           
            if(socialLink!=null && socialLink.Platform !=null && socialLink.Url !=null && socialLink.IconClass != null)
            {
                _context.SocialLink.Add(socialLink);
                _context.SaveChanges();
                return Json(new { success = true, msg = "Data saved!"});
            }

            //return Json(new { success = false, message = "Invalid data!" });

            return Json(new { success=false, msg = "not saved!", sdf="asdf" });

        }

    }
}
