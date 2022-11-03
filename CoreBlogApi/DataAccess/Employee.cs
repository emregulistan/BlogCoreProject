using System.ComponentModel.DataAnnotations;

namespace CoreBlogApi.DataAccess
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
