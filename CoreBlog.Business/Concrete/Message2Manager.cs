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
    public class Message2Manager : IMessage2Service
    {
        IMessage2 _message2;

        public Message2Manager(IMessage2 message2)
        {
            _message2 = message2;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _message2.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _message2.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
