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
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }

        public List<Message2> GetSendBoxWithMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Message2s.Include(x => x.ReceiverUser).Where(y => y.SenderID == id).ToList();
            }
        }
    }
}
