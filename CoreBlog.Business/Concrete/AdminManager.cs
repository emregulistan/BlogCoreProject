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
    public class AdminManager : IAdminService
    {
        IAdmin _admin;

        public AdminManager(IAdmin admin)
        {
            _admin = admin;
        }

        public List<Admin> GetList()
        {
            return _admin.GetListAll();
        }

        public void TAdd(Admin t)
        {
            _admin.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _admin.Delete(t);
        }

        public Admin TGetById(int id)
        {
            return _admin.GetByID(id);
        }

        public void TUpdate(Admin t)
        {
            _admin.Update(t);
        }
    }
}
