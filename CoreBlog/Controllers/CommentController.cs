using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager _commentManager = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}		
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 1034;
			_commentManager.TAdd(p);
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = _commentManager.GetList(id);
			return PartialView(values);
		}
	}
}
