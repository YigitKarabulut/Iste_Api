using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Iste_Api.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; }
        public string RefreshToken { get; set; }
    }
}
