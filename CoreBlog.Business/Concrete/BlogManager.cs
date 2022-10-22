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

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blog.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
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
	}
}
