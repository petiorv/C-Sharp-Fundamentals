using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double len = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(len, width, height);
                Console.WriteLine($"Surface Area - {box.SurfaceArea:F2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea:F2}");
                Console.WriteLine($"Volume - {box.Volume:F2}");

            }
            catch (ArgumentException e)
            {                
                Console.WriteLine(e.Message);
            }

        }
    }
}
