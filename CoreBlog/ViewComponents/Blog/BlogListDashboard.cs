using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace CoreBlog.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke() 
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
