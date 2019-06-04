using Mcastrobruno.Splitter;
using System;


namespace splitter_sample
{
    public class Program
    {
        static StringSplitter _splitter = new StringSplitter();
        static void Main(string[] args)
        {


            Console.WriteLine("Enter with the text to be splitted:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter with the maximum length:");
            if (int.TryParse(Console.ReadLine(), out int length))
            {
                string result = _splitter.Split(text, 1);
                Console.WriteLine($"Splited text: ");
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Wrong length. Try again.");
        }
    }
}
