using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string[] in1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] in2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Student student = new Student(in1[0], in1[1], in1[2]);
            Worker worker = new Worker(in2[0], in2[1], decimal.Parse(in2[2]), decimal.Parse(in2[3]));


            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException e)
        {

            Console.WriteLine(e.Message);
        }

    }
}
