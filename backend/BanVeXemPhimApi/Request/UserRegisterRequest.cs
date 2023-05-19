using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXemPhimApi.Request
{
    public class UserRegisterRequest
    {
        [Required]
        public string NumberPhone { get; set; }
        [Required, EmailAddress]
        public string Username { get; set; }
        [Required, MinLength(8)]
        public string Password { get; set; }
    }
}
