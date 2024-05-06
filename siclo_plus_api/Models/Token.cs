using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.Models
{
    public class Token
    {
        public string token { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public int ExpiresIn { get; set; }

        public string TokenType { get; set; }
    }
}
