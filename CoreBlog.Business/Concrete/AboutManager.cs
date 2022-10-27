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
	public class AboutManager : IAboutService
	{
		IAbout _about;

		public AboutManager(IAbout about)
		{
			_about = about;
		}

		public About TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> GetList()
		{
			return _about.GetListAll();
		}

		public void TAdd(About t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(About t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(About t)
		{
			throw new NotImplementedException();
		}
	}
}
