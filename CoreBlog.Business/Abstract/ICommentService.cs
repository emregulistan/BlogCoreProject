using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> GetCommentWithBlog();
    }
}
