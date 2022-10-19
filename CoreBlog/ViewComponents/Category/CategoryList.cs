using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Category
{
	public class CategoryList: ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryRepository());
		
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
