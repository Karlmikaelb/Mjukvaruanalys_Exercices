using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Knight : Creature
    {
        protected string Weapon { get; set; }

        public Knight(string name, string weapon) : base (name)
        {
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine("Knight " + Name + " attacks with his " + Weapon);
        }
    }
}
