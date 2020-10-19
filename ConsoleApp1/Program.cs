using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bobby = new Dog
            {
                Color = "Yellow",
                EyeColor = "Brown",
                Height = 17,
                Length = 35,
                Weight = 24
            };

            bobby.Sit();
        }
    }
}
