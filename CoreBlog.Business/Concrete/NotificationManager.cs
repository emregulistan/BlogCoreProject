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
    public class NotificationManager : INotificationService
    {
        INotification _notification;

        public NotificationManager(INotification notification)
        {
            _notification = notification;
        }

        public List<Notification> GetList()
        {
            return _notification.GetListAll();
        }

        public void TAdd(Notification t)
        {
            _notification.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _notification.Delete(t);
        }

        public Notification TGetById(int id)
        {
            return _notification.GetByID(id);
        }

        public void TUpdate(Notification t)
        {
            _notification.Update(t);
        }
    }
}
