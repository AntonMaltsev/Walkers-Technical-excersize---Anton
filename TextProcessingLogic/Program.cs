using System;
using TextProcessingLogic.Common;

namespace TextProcessingLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walkers Technical Assessment - Anton");
            Console.WriteLine("Please enter number between 1 and 200");

            if (int.TryParse(Console.ReadLine() ?? string.Empty, out var inputNumber))
                Console.WriteLine("Entered number is not valid");

            var a = new NumbersDisplaying();
            a.DisplayFullSquence(inputNumber);
        }
    }
}
