using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
