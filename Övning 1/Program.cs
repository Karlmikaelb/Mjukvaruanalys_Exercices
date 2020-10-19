using Exercice_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(6);

            var value = dice.ThrowDice();

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
