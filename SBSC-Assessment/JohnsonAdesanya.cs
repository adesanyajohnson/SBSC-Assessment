using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSC_Assessment
{
    public class JohnsonAdesanya
    {
        public bool hyphenSeperatedNumbers(string hyphenSeperated)
        {
            if (string.IsNullOrEmpty(hyphenSeperated))
                return false;

            List<string> splitString = hyphenSeperated.Split('-').ToList<string>();
            int interval = 0, difference = 0, listLength = splitString.Count;

            for (int i = 0; i < listLength; i++)
            {
                if (i == 0)
                    interval = int.Parse(splitString[i + 1]) - int.Parse(splitString[i]);
                else
                    difference = int.Parse(splitString[i + 1]) - int.Parse(splitString[i]);

                if (i != 0 && interval != difference)
                    return false;
            }

            return true;
        }

        public string stringRepeatedLetters(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            string outputString = string.Empty;
            Char[] inputStringArray = inputString.ToCharArray();

            foreach (char item in inputStringArray)
            {
                int numOfOccurence = inputString.TakeWhile(x => x == item).Count();
                string.Concat(outputString, numOfOccurence.ToString());
            }

            return outputString;
        }
    }
}
