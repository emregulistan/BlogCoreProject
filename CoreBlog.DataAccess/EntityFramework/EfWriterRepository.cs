using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Repositories;
using CoreBlog.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccess.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriter
    {
    }
}
