using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleWatch
{
    class LCDDisplay
    {
        public int BlinkIdx { get; set; }

        public void BlinkSeconds(int sec, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till den enkla klockan");
                Console.WriteLine();
                Console.WriteLine("Meny");
                Console.WriteLine("1. Visa Tid");
                Console.WriteLine("2. Tryck på knappen");
                Console.WriteLine("3. Byt ut batterier");
                Console.WriteLine("4. Sätt blinkintervall i sekunder");
                Console.WriteLine("5. Avsluta blinkning");
                Console.WriteLine("6. Avsluta program");
                Thread.Sleep(sec * 1000);
            }
            StopBlinking();
        }

        public void StopBlinking()
        {
            Console.WriteLine("Startar om programmet 5 sekunder");
            Thread.Sleep(5000);

            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
