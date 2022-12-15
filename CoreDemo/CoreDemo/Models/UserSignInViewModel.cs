using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz...")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Şifreyi Giriniz...")]
        public string Password { get; set; }
    }
}
