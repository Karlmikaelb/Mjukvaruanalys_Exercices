using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Dice
    {
        public int Sides { get; set; }

        public Dice(int nrOfSides)
        {
            Sides = nrOfSides;
        }

        public int ThrowDice()
        {
            var random = new Random();

            return random.Next(1, Sides + 1);
        }
    }
}
