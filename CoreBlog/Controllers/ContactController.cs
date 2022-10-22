using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{

    public class ContactController : Controller
	{
        ContactManager cm = new ContactManager(new EfContactRepository());

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}		
		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			cm.ContactAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
