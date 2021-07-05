using System;
using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Common
{
    public class NumbersDisplaying : INumbersDisplaying
    {
        public void DisplayFullSquence(int inputNumber)
        {
            var processing = new NumberProcessing();

            for (var i = 1; i < inputNumber + 1; i++)
            {
                SetTextColour(processing.BasicProcessor(i));
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
                    Console.Write("assessment");
                    break;
                default:
                    Console.WriteLine(text);
                    break;
            }
        }
    }
}
