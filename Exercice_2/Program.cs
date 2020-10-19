using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Creature creature = new Creature("Wolf");
            Knight knight = new Knight("Kalle", "Sword");
            Dragon dragon = new Dragon("Erik", "Orange");

            var creatureInfo = creature.GetInfo();

            Console.WriteLine("Kalle and his wolf are walking in the forest");
            Console.WriteLine("Press 1 to see some information about Kalles wolf or 0 to continue anyway");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine(creatureInfo);
                Thread.Sleep(5000);
            }

            Console.Clear();
            Console.WriteLine("Suddenly a wild dragon appears!");
            Thread.Sleep(2000);
            knight.Attack();
            Thread.Sleep(2000);
            dragon.Attack();
            Console.ReadLine();
        }
    }
}
