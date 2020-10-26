using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWatch
{
    class Time
    {
        public string TimeOfClock()
        {
            var time = new DateTime();
            return time.ToString("hh.mm");
        }
    }
}
