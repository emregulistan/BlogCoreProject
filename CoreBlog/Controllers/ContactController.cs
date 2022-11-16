using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	[AllowAnonymous]
    public class ContactController : Controller
	{
        ContactManager _contactManager = new ContactManager(new EfContactRepository());

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
			_contactManager.TAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
