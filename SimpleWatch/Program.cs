using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleWatch
{
    class SimpleWatch
    {
        static void Main(string[] args)
        {
            LCDDisplay display = new LCDDisplay();

            Console.WriteLine("Välkommen till den enkla klockan");
            Console.WriteLine();
            Console.WriteLine("Gör ett val i menyn nedanför...");
            Console.WriteLine();
            Console.WriteLine("Meny");
            Console.WriteLine("1. Visa Tid");
            Console.WriteLine("2. Tryck på knappen");
            Console.WriteLine("3. Byt ut batterier");
            Console.WriteLine("4. Sätt blinkintervall i sekunder");
            Console.WriteLine("5. Avsluta program");
            
            var userInput = int.Parse(Console.ReadLine());
            

            if (userInput == 1)
            {
                Time time = new Time();
                Console.Write("Klockan är: " + time.TimeOfClock());
                Console.ReadKey();

                Console.WriteLine("Startar om programmet 5 sekunder");
                Thread.Sleep(5000);

                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
            }

            if (userInput == 2)
            {
                PushButton button = new PushButton();
                button.Push();
                Console.ReadLine();

                Console.WriteLine("Startar om programmet 5 sekunder");
                Thread.Sleep(5000);

                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
            }

            if (userInput == 3)
            {
                Battery battery = new Battery();
                battery.Load();
            }

            if (userInput == 4)
            {       
                Console.WriteLine("Hur många sekunder vill du att det ska vara mellan blinkningarna?");
                display.BlinkIdx = int.Parse(Console.ReadLine());

                Console.WriteLine("Hur många gånger vill du att det ska blinka?");
                var nrOfBlinks = int.Parse(Console.ReadLine());

                display.BlinkSeconds(display.BlinkIdx, nrOfBlinks);
            }

            if (userInput == 5)
            {
                Environment.Exit(0);
            }
        }
    }
}
