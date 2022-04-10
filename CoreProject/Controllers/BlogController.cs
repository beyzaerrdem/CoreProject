using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
