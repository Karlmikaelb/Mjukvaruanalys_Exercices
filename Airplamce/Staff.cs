using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Airplamce
{
    class Staff
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Staff (string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
