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

		public void WriterAdd(Writer writer)
		{
			_writer.Insert(writer);
		}
	}
}
