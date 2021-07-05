using System;
using TextProcessing.Logic.Interfaces;

namespace TextProcessing.Logic.Common
{
    public class NumberProcessing : INumbersProcessing
    {
        private const string ReplaceWalkersRule = "walkers";
        private const string ReplaceAssessmentRule = "assessment";
        private const string MondayWalkersRule = "walkers-m";
        private const string MondayAssessmentRule = "assessment-m";

        public string BasicProcessor(int sequenceElement)
        {
            var output = string.Empty;

            if (sequenceElement % 3 == 0)
            {
                output = MondayCheck(ReplaceWalkersRule);

                if (sequenceElement % 5 == 0)
                {
                    output +=  $" {MondayCheck(ReplaceAssessmentRule)}";
                }
            }
            else if (sequenceElement % 5 == 0)
            {
                output = MondayCheck(ReplaceAssessmentRule);
            }

            return output == string.Empty ? sequenceElement.ToString() : output;
        }

        public string MondayCheck(string value)
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                return value switch
                {
                    ReplaceWalkersRule => MondayWalkersRule,
                    ReplaceAssessmentRule => MondayAssessmentRule,
                    _ => value
                };

            return value;
        }
    }
}
