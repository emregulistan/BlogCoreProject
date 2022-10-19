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
	public class CommentManager : ICommentService
	{
		IComment _comment;

		public CommentManager(IComment comment)
		{
			_comment = comment;
		}

		public void CommentAdd(Comment comment)
		{
			_comment.Insert(comment);
		}

		public List<Comment> GetList(int id)
		{
			 return _comment.GetListAll(x => x.BlogID == id);
		}
	}
}
