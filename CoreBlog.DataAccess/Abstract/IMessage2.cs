using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccess.Abstract
{
    public interface IMessage2 : IGeneric<Message2>
    {
        List<Message2> GetListWithMessageByWriter(int id);
    }
}
