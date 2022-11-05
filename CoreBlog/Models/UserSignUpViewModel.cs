using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace CoreBlog.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail Adresi")]
        public string Mail { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
    }

}
