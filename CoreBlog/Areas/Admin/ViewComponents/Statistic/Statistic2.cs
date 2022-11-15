using CoreBlog.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x=>x.BlogTitle).Take
                (1).FirstOrDefault();
            ViewBag.v2 = c.Comments.Count();
            ViewBag.v3 = c.Contacts.Count();
            return View();
        }
    }
}
