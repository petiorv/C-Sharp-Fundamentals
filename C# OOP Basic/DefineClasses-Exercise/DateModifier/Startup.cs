using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class Startup
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();
            dateModifier.CaclDifference(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(dateModifier.DifferenceInDays);
        }
    }
}
