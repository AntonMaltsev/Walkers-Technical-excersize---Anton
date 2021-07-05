using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Common
{
    public class NumberValidating : INumberValidation

    {
        public bool BasicValidation(int inupt)
        {
            return inupt >= 1 && inupt <= 200;
        }
    }
}
