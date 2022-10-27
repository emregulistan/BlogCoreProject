using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.EntityFramework;
using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategory _category;
        public CategoryManager(ICategory category)
        {
            _category = category;
        }
        public void TAdd(Category t)
        {
            _category.Insert(t);
        }

        public void TDelete(Category t)
        {
            _category.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _category.Update(t);
        }
        public Category TGetById(int id)
        {
            return _category.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _category.GetListAll();
        }
    }
}
