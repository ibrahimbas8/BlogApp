using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserUpdateViewModel
    {
        public string nameSurname { get; set; }
        public string userName { get; set; }
        public string mail { get; set; }
        public string imgUrl { get; set; }
        public string password { get; set; }
    }
}
