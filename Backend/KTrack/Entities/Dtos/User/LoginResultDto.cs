using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class LoginResultDto
    {
        public string Token { get; set; } = "";

        public DateTime Expiration { get; set; }
    }
}
