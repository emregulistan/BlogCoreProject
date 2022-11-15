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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetter _newsletter;

        public NewsLetterManager(INewsLetter newsletter)
        {
            _newsletter = newsletter;
        }

        public List<NewsLetter> GetList()
        {
            return _newsletter.GetListAll();
        }

        public void TAdd(NewsLetter t)
        {
            _newsletter.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            _newsletter.Delete(t);
        }

        public NewsLetter TGetById(int id)
        {
            return _newsletter.GetByID(id);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsletter.Update(t);
        }
    }
}
