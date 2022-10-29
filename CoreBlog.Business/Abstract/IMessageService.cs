using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}
