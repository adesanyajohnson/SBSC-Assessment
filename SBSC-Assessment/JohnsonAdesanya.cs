using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSC_Assessment
{
    public class JohnsonAdesanya
    {
        public JohnsonAdesanya()
        {

        }

        public bool Question1(string hyphenSeperated)
        {
            if (string.IsNullOrEmpty(hyphenSeperated))
                return false;

            List<string> splitString = hyphenSeperated.Split('-').ToList<string>();
            int interval = 0, difference = 0, listLength = splitString.Count;

            for (int i = 0; i < listLength - 1; i++)
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

        public int Question2(List<int> inputIntegerList)
        {
            List<int> outputIntegerList = new List<int>();
            int absDifference = 0, listLength = inputIntegerList.Count;
            int kPosition = -1;

            for (int i = 0; i < listLength - 1; i++)
            {
                absDifference = Math.Abs(inputIntegerList[i + 1] - inputIntegerList[i]);

                if (!inputIntegerList.Contains((int)absDifference))
                {
                    inputIntegerList.Add(absDifference);
                    listLength += 1;
                }
                else
                {
                    kPosition = listLength + 1;
                    break;
                }
            }

            return kPosition;
        }

        public string Question3(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            string outputString = string.Empty;
            char[] inputStringArray = inputString.ToCharArray().Distinct().ToArray<char>();

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                char currentChar = inputStringArray[i];
                int numOfOccurence = inputString.Where(x => x == currentChar).Count();
                outputString = string.Concat(outputString, currentChar, numOfOccurence.ToString());
            }

            return outputString;
        }
    }
}
