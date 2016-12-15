using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticGenerator.Models
{
    public class AuthenticationMetaData
    {
        public string Name { get; set; }
        public Func<string> GetConnectionString { get; set; }
    }
}
