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
        public List<Message> GetList(string receiveEmail)
        {
            return _message.GetListAll(w => w.Receiver == receiveEmail);
        }


        public void TAdd(Message t)
        {
            _message.Insert(t);
        }

        public void TDelete(Message t)
        {
            _message.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _message.GetByID(id);
        }

        public void TUpdate(Message t)
        {
            _message.Update(t);
        }
    }
}
