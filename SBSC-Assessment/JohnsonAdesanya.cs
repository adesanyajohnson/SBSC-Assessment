using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSC_Assessment
{
    public class JohnsonAdesanya
    {
        public bool Question1(string hyphenSeperated)
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

        public string Question3(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            string outputString = string.Empty;
            Char[] inputStringArray = inputString.ToCharArray();

            foreach (char item in inputStringArray)
            {
                int numOfOccurence = inputString.TakeWhile(x => x == item).Count();
                outputString = string.Concat(item, numOfOccurence.ToString());
            }

            return outputString;
        }

        public int Question2(List<int> inputIntegerList)
        {
            List<int> outputIntegerList = new List<int>();
            int absDifference = 0, listLength = inputIntegerList.Count;
            int kPosition = -1;

            for (int i = 0; i < listLength; i++)
            {
                absDifference = Math.Abs(inputIntegerList[i + 1] - inputIntegerList[i]);

                if (!inputIntegerList.Contains((int)absDifference))
                {
                    outputIntegerList.Add(absDifference);
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
    }
}
