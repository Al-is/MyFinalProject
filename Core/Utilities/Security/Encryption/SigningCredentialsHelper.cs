using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
  public  class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSingningCredentials(SecurityKey securityKey)
        {//hangi anahtar hangi algoritma kullanılacak 

            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
