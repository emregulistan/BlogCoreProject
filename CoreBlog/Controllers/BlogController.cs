using CoreBlog.Business.Concrete;
using CoreBlog.Business.ValidationRules;
using CoreBlog.DataAccess.Concrete;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlog.Controllers
{  
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        CategoryManager _categoryManager = new CategoryManager(new EFCategoryRepository());
        Context c = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.blog = id;
            var values = _blogManager.GetBlogByID(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogListByWriter()
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = _blogManager.GetListWithCategoryByWriterBm(writerID);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in _categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categoryList = categoryvalues;
            return View();
        }        
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = writerID;
                _blogManager.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = _blogManager.TGetById(id);
            _blogManager.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = _blogManager.TGetById(id);
            List<SelectListItem> categoryvalues = (from x in _categoryManager.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var blogValue = _blogManager.TGetById(p.BlogID);
            p.WriterID = writerID;
            p.BlogCreateDate = DateTime.Parse(blogValue.BlogCreateDate.ToShortDateString());
            p.BlogStatus = true;
            _blogManager.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
