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
			throw new NotImplementedException();
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
			throw new NotImplementedException();
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
