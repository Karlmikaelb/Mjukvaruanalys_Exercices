using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Dragon : Creature
    {
        protected string Color { get; set; }

        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }

        public void Attack()
        {
            Console.WriteLine(Color + " dragon " + Name + " attacks with fire");
        }
    }
}
