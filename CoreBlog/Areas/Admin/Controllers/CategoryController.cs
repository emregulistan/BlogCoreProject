using CoreBlog.Business.Concrete;
using CoreBlog.Business.ValidationRules;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");
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
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }
    }

}

