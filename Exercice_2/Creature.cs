using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        protected string Name { get; set; }

        public Creature(string name)
        {
            Name = name;
        }

        public string GetInfo()
        {
            var random = new Random();
            Health = random.Next(100, 500);
            Shield = random.Next(50, 200);

            var info = "Name: " + Name + "\nHealth: " + Health + "\nShield: " + Shield;

            return info;
        }
    }
}
