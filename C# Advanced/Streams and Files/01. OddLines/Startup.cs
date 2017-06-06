using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class Startup
    {
        private const string TestFile = "Text.txt";

        static void Main(string[] args)
        {
            PrepareTestFile();
            PrintOddLines();
        }


        private static void PrintOddLines()
        {
            using (StreamReader reader = new StreamReader(TestFile))
            {
                string line = reader.ReadLine();
                int lineCounter = 0;
                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineCounter++;
                    line = reader.ReadLine();
                }
            }
        }


        static void PrepareTestFile()
        {
            using (StreamWriter writer = new StreamWriter(TestFile))
            {
                for (int i = 0; i < 99; i++)
                {
                    if (i % 2 == 0)
                    {
                        writer.WriteLine($"{i}.Even");
                    }
                    else
                    {
                        writer.WriteLine($"{i}.Odd");
                    }
                }
            }
        }
    }
}
