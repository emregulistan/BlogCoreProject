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

        public List<Comment> GetCommentWithBlog()
        {
            return _comment.GetListWithBlog();
        }

        public List<Comment> GetList()
        {
            return _comment.GetListAll();
        }

        public List<Comment> GetList(int id)
        {
            return _comment.GetListAll(x => x.BlogID == id);
        }

        public void TAdd(Comment t)
		{
            _comment.Insert(t);
        }

        public void TDelete(Comment t)
		{
            _comment.Delete(t);
        }

        public Comment TGetById(int id)
		{
            return _comment.GetByID(id);
        }

        public void TUpdate(Comment t)
		{
            _comment.Update(t);
        }
    }
}
