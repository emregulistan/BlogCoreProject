﻿using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Abstract
{
	public interface IWriterService : IGenericService<Writer>
	{
		List<Writer> GetWriterById(int id);
	}
}
