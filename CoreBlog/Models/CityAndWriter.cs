using CoreBlog.Entity.Concrete;
using System.Collections.Generic;

namespace CoreBlog.Models
{
    public class CityAndWriter
    {
        public List<Cities> Cities { get; set; }
        public List<Writer> Writers { get; set; }
    }
}
