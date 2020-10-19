using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class VendingMachine
    {       
        public bool Restocked { get; set; }
        public bool Serviced { get; set; }
        public bool Emptied { get; set; }
        public int[] Coins { get; set; } = new int[4];
    }
}
