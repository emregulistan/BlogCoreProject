using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public IActionResult Index(int page =1)
        {
            var values = commentManager.GetCommentWithBlog().ToPagedList(page, 20);
            return View(values);
        }

        [HttpPost]
        public IActionResult DeleteComment(int id, bool isDelete = false)
        {

            var value = commentManager.TGetById(id);
            commentManager.TUpdate(value);
            return View();
        }
    }
}