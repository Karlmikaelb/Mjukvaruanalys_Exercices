using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleWatch
{
    class PushButton
    {
        public bool State { get; set; }

        public void Push()
        {
            Console.WriteLine("Du tryckte på knappen");
            Thread.Sleep(3000);
            Release();
        }

        public void Release()
        {
            Console.WriteLine("Du slutade trycka på knappen");
        }
    }
}
