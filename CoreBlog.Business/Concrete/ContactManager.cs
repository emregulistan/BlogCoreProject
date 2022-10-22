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

		public void ContactAdd(Contact contact)
		{
			_contact.Insert(contact);
		}
	}
}
