using System;
using System.Runtime.CompilerServices;
using TextProcessingLogic.Interfaces;

namespace TextProcessingLogic.Common
{
    public class NumbersDisplaying : INumbersDisplaying
    {
        public void DisplayFullSquence(int inputNumber)
        {
            var processing = new NumberProcessing();

            for (var i = 1; i < inputNumber + 1; i++)
            {
                Console.WriteLine(processing.BasicProcessor(i));
            }
        }
    }
}
