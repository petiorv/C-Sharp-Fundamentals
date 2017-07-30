

using System;
public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int intValue))
            {
                var box = new Box<int>(intValue);
                Console.WriteLine(box);
            }
            else
            {
                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
