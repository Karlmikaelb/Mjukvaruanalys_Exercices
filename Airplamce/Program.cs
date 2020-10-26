using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplamce
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff pilot = new Staff("Kalle", "Pilot");
            Staff attendant = new Staff("Elina", "Flight Attendant");

            Console.WriteLine("Våran personal som jobbar idag är " + pilot.Name + " - "  + pilot.Role);
            Console.ReadLine();

            Adult adult = new Adult();
            Children children = new Children();

            adult.Name = "Kalle";

            Console.WriteLine("Hur gammal är du?");
            var x = int.Parse(Console.ReadLine());

            if (x >= 30)
            {
                adult.Menu();
            }
            else
            {
                children.Menu();
            }
        }
    }
}
