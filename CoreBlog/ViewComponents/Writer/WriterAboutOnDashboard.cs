using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterById(1);
            return View(values);
        }

    }
}
