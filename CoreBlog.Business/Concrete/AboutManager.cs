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

		public List<About> GetList()
		{
			return _about.GetListAll();
		}
	}
}
