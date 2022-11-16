using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete;
using CoreBlog.DataAccess.Repositories;
using CoreBlog.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccess.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, IComment
    {
        public List<Comment> GetListWithBlog()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Blog).ToList();
            }        
        }
    }
}
