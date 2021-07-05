using System;
using TextProcessing.Logic.Common;

namespace TextProcessing.Logic
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Walkers Technical Assessment - Anton");
            Console.WriteLine("Please enter number between 1 and 200");

            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out var inputNumber))
                Console.WriteLine("Entered number is not valid");

            var display = new NumbersDisplaying();
            display.DisplayFullSquenceWithPaging(inputNumber, 20);
            Console.WriteLine();
        }
    }
}
