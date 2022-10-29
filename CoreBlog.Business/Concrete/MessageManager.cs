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
    public class MessageManager : IMessageService
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _message.GetListAll(x=>x.Receiver == p);
        }

        public List<Message> GetList()
        {
            return _message.GetListAll();
        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
