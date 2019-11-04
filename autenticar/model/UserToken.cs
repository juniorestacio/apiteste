using System;

namespace autenticar.model
{
    public class UserToken
    {
         public string Token { get; set; }
         public DateTime Expiration { get; set; }
    }
}