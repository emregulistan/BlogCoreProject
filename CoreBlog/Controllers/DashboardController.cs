using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class DashboardController : Controller
    {
        private BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        private CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context context = new Context();
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            ViewBag.blogsCount = _blogManager.GetList().Count;
            ViewBag.blogCountByWriter = _blogManager.GetBlogListByWriter(writerId).Count;
            ViewBag.categoriesCount = _categoryManager.GetList().Count;
            return View();
        }
    }
}
