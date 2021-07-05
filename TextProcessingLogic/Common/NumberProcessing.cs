using TextProcessingLogic.Interfaces;

namespace TextProcessingLogic.Common
{
    public class NumberProcessing : INumbersProcessing
    {
        private const string replaceWalkersRule = "walkers";
        private const string replaceAssessmentRule = "assessment";

        public string BasicProcessor(int sequenceElement)
        {
            var output = string.Empty;

            if (sequenceElement % 3 == 0)
            {
                output = replaceWalkersRule;

                if (sequenceElement % 5 == 0)
                {
                    output +=  $" {replaceAssessmentRule}";
                }
            }
            else if (sequenceElement % 5 == 0)
            {
                output = replaceAssessmentRule;
            }

            return output == string.Empty ? sequenceElement.ToString() : output;
        }
    }
}
