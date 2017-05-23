using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();
            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amoutOfGas = int.Parse(pumpInfo[0]);
                GasPump pump = new GasPump(distanceToNext, amoutOfGas, i);
                pumps.Enqueue(pump);
            }

            GasPump starterPump = null;
            bool completeJourney = false;

            while (true)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);

                starterPump = currentPump;
                int gasInTank = currentPump.amountOfGas;

                while (gasInTank >= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;

                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                   

                    if (currentPump == starterPump)
                    {
                        completeJourney = true;
                        break;
                    }
                    gasInTank += currentPump.amountOfGas;
                }
                if (completeJourney)
                {
                    Console.WriteLine(currentPump.indexOfPump);
                    break;
                }
            }
        }
    }
    public class GasPump
    {
        public int distanceToNext;
        public int amountOfGas;
        public int indexOfPump;

        public GasPump(int distancetoNext, int amountOfGas, int indexOfPump)
        {
            this.distanceToNext = distancetoNext;
            this.amountOfGas = amountOfGas;
            this.indexOfPump = indexOfPump;
        }
    }
}
