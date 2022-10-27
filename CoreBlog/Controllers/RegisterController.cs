using CoreBlog.Business.Concrete;
using CoreBlog.Business.ValidationRules;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator(); ;
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme Test";
				wm.TAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
