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

        public void AddNewsLetter(NewsLetter newsletter)
        {
            _newsletter.Insert(newsletter);
        }
    }
}
