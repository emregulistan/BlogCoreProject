using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class AdminController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
