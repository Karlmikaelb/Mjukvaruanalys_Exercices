using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public int Amount { get; set; }

        public bool CancelTrans(int id)
        {

        }

        public bool Purchase(int amount, bool InStock)
        {

        }

        public int ReturnChange(int amount, int articlePrice)
        {

        }
    }
}
