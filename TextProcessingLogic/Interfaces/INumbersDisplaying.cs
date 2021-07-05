using System;

namespace TextProcessing.Logic.Interfaces
{
    public interface INumbersDisplaying
    {
        void DisplayFullSquence(int startNumber, int inputNumber);

        public void DisplayFullSquenceWithPaging(int inputNumber, int pageSize);
    }
}
