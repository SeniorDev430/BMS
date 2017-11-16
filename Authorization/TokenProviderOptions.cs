﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization
{
    public class TokenProviderOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public TimeSpan Expiration { get; set; } = TimeSpan.FromMinutes(5);
        public SigningCredentials SigningCredentials { get; set; }
    }
}
