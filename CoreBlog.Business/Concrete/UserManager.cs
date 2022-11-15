using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Concrete
{
	public class UserManager : IUserService
	{
		IUser _user;

		public UserManager(IUser user)
		{
			_user = user;
		}

		public List<IdentityUser> GetList()
		{
			throw new NotImplementedException();
		}

		public void TAdd(IdentityUser t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(IdentityUser t)
		{
			throw new NotImplementedException();
		}

		public IdentityUser TGetById(int id)
		{
            return _user.GetByID(id);
        }

        public void TUpdate(IdentityUser t)
		{
            _user.Update(t);
        }
    }
}
