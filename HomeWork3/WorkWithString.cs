using System;

namespace HomeWork3
{
    class WorkWithString
    {
        private string _inputString;
        public WorkWithString(string inputString)
        {
            _inputString = inputString;
        }

        public bool isPolindrom()
        {
            string headOfString;
            string tailOfString;
            string inputStringWithoutSpaces = removeSpacesFromString(_inputString);
            inputStringWithoutSpaces = inputStringWithoutSpaces.Replace(" ", string.Empty);
            if (inputStringWithoutSpaces.Length % 2 == 0)
            {
                 headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2);
                 tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length);
            }
            else
            {
                 headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2);
                 tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length + 1);
            }
            tailOfString = returnReverseString(tailOfString);            
            if (tailOfString.Equals(headOfString))
                return true;
            else
                return false;
        }

        public string returnReverseString(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int countsHowManyWordsPerLine()
        {
            string inputStringWithoutSpaces = removeSpacesFromString(_inputString);
            string[] textArray = _inputString.Split(new char[] { ' ' });
            return textArray.Length;
        }

        public string removeSpacesFromString(string inputString)
        {
            while (inputString.Contains("  ") || inputString.Contains(".") || inputString.Contains(","))
                inputString = inputString.Replace(",", " ").Replace(".", " ").Replace("  ", " ");
            inputString = inputString.Trim();
            return inputString;
        }
    }
}
