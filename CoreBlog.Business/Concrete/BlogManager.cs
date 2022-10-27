using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlog _blog;

		public BlogManager(IBlog blog)
		{
			_blog = blog;
		}
		public List<Blog> GetBlogListWithCategory()
		{
			return _blog.GetListWithCategory();
		}
		public List<Blog> GetListWithCategoryByWriterBm(int id)
		{
			return _blog.GetListWithCategoryByWriter(id);
		}
		public Blog TGetById(int id)
		{
			return _blog.GetByID(id);
        }

        public List<Blog> GetBlogByID(int id)
		{
			return _blog.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> GetList()
		{
			return _blog.GetListAll();
		}
		public List<Blog> GetLast3Blog()
		{
			return _blog.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blog.GetListAll(x => x.WriterID == id);
		}

		public void TAdd(Blog t)
		{
			_blog.Insert(t);
		}

		public void TDelete(Blog t)
		{
			_blog.Delete(t);
		}

		public void TUpdate(Blog t)
		{
			_blog.Update(t);
		}
	}
}
