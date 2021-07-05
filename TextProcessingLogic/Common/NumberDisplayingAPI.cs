using System;
using System.Collections.Generic;
using System.Drawing;
using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Common
{
    public class NumbersDisplayingAPI : INumbersDisplaying
    {
        private Dictionary<int, string> outputValuesDictionary;

        public void DisplayFullSquence(int startNumber, int inputNumber)
        {
            // TODO: API specific implementation
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
    }
}
