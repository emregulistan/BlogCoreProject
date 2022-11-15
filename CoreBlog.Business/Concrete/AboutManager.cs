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
            return _about.GetByID(id);
		}

		public List<About> GetList()
		{
			return _about.GetListAll();
		}

		public void TAdd(About t)
		{
            _about.Insert(t);
		}

		public void TDelete(About t)
		{
            _about.Delete(t);
		}

		public void TUpdate(About t)
		{
            _about.Update(t);
		}
	}
}
