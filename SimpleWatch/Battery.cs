using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleWatch
{
    class Battery
    {
        public void Load()
        {
            Console.WriteLine("Du lyckade byta ut dina batterier. Grattis!");

            Console.WriteLine("Startar om programmet 5 sekunder");
            Thread.Sleep(5000);

            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
