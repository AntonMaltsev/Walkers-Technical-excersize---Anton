using System;
using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Common
{
    public class NumbersDisplaying : INumbersDisplaying
    {
        public void DisplayFullSquence(int startNumber, int inputNumber)
        {
            var processing = new NumberProcessing();

            for (var i = startNumber + 1; i < inputNumber + 1; i++)
            {
                SetTextColour(processing.BasicProcessor(i));
            }

            Console.WriteLine("Next 20");
            Console.ReadKey();
        }

        public void DisplayFullSquenceWithPaging(int inputNumber, int pageSize)
        {
            var pageNumber = 0;
            int endPeriod;

            while (pageNumber * pageSize < inputNumber)
            {
                endPeriod = (pageNumber + 1) * pageSize < inputNumber ? (pageNumber + 1) * pageSize: inputNumber;
                DisplayFullSquence(pageNumber * pageSize, endPeriod);
                pageNumber++;
            } 
        }

        private void SetTextColour(string text)
        {
            switch (text)
            {
                case "walkers":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    break;
                case "assessment":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    break;
                case "walkers assessment":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("walkers ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("assessment");
                    break;
                default:
                    Console.WriteLine(text);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
