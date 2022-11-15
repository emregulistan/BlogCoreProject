using CoreBlog.Entity.Concrete;
using Microsoft.AspNetCore.Identity;

namespace CoreBlog.DataAccess.Abstract
{
    public interface IUser : IGeneric<IdentityUser>
    {
    }
}
