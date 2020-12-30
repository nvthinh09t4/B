using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.Configuration
{
    public class ExternalLoginConfig
    {
        public List<ExternalLogin> ExternalLogins { get; set; }
    }
    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
    }
}
