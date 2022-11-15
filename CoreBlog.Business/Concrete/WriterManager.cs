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
	public class WriterManager : IWriterService
	{
		IWriter _writer;

		public WriterManager(IWriter writer)
		{
			_writer = writer;
		}
        public List<Writer> GetList()
        {
            return _writer.GetListAll();
        }
        public List<Writer> GetList(int id)
        {
            return _writer.GetListAll(w => w.WriterID == id);
        }
        public List<Writer> GetList(string email)
        {
            return _writer.GetListAll(w => w.WriterMail == email);
        }

        public List<Writer> GetWriterById(int id)
		{
			return _writer.GetListAll(x => x.WriterID == id);
		}

		public void TAdd(Writer t)
		{
            _writer.Insert(t);
        }

        public void TDelete(Writer t)
		{
            _writer.Delete(t);
        }

        public Writer TGetById(int id)
		{
            return _writer.GetByID(id);
        }

        public void TUpdate(Writer t)
		{
			_writer.Update(t);
		}

	}
}
