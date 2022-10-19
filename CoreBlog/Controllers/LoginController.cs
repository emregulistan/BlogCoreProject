using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
