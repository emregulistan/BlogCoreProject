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
	public class ContactManager : IContactService
	{
		IContact _contact;

		public ContactManager(IContact contact)
		{
			_contact = contact;
		}

		public List<Contact> GetList()
		{
            return _contact.GetListAll();
        }

        public void TAdd(Contact t)
		{
            _contact.Insert(t);
        }

        public void TDelete(Contact t)
		{
            _contact.Delete(t);
        }

        public Contact TGetById(int id)
		{
            return _contact.GetByID(id);
        }

        public void TUpdate(Contact t)
		{
            _contact.Update(t);
        }
    }
}
