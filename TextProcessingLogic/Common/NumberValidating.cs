using TextProcessingLogic.Interfaces;

namespace TextProcessingLogic.Common
{
    public class NumberValidating : INumberValidation

    {
        public bool BasicValidation(int inupt)
        {
            return inupt >= 1 && inupt <= 200;
        }
    }
}
