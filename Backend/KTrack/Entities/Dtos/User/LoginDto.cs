using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class LoginDto
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}
