using HSJProject.Data;
using HSJProject.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace HSJProject.Controllers
{
    public class BlogsController : Controller
    {
        private readonly HSJProjectContext _context;

        public BlogsController(HSJProjectContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Blog
                .Select(b => new Blog
                {
                    BlogId = b.BlogId,
                    BlogTitle = b.BlogTitle,
                    BlogContent = b.BlogContent != null && b.BlogContent.Length > 50
                        ? b.BlogContent.Substring(0, 50)
                        : b.BlogContent,
                    BlogThumbnails = b.BlogThumbnails
                })
                .ToList();

            return View(data);
        }
        public IActionResult Details(int id)
        {
            var blog = _context.Blog.LastOrDefault( johan => johan.BlogId == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        public IActionResult BlogList()
        {
             
            var blogdata = _context.Blog.Select(
                b => new Blog
                {
                    BlogId = b.BlogId,
                    BlogTitle = b.BlogTitle,
                    BlogThumbnails = b.BlogThumbnails,
                    BlogContent = b.BlogContent != null && b.BlogContent.Length > 50
                        ? b.BlogContent.Substring(0, 50)
                        : b.BlogContent,

                } ).ToList();
            
            return View(blogdata);
        }
        public IActionResult BlogCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogCreate(Blog blogmodel)
        {
            _context.Blog.Add(blogmodel);
            _context.SaveChanges();
            return RedirectToAction("BlogList");
        }
    }
}
