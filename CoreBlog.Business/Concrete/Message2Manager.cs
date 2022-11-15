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
        public List<Message2> GetSendBoxListMessageByWriter(int id)
        {
            return _message2.GetSendBoxWithMessageByWriter(id);
        }
        public List<Message2> GetList()
        {
            return _message2.GetListAll();
        }
        public List<Message2> GetList(int id)
        {
            return _message2.GetListAll(w => w.ReceiverID == id);
        }

        public void TAdd(Message2 t)
        {
            _message2.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _message2.Delete(t);
        }

        public Message2 TGetById(int id)
        {
            return _message2.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            _message2.Update(t);
        }
        Message2 IGenericService<Message2>.TGetById(int id)
        {
            return _message2.GetByID(id);
        }
    }
}
