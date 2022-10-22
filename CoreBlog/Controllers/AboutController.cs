using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {

            return PartialView();
        }
    }
}
