using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private AboutManager _aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var socialMedias = _aboutManager.GetList();
            return View(socialMedias);
        }
        public PartialViewResult SocialMediaAbout()
        {
            var socialMedias = _aboutManager.GetList();
            return PartialView();
        }
    }
}
