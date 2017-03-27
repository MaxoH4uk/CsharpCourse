using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string inputStringWithoutSpaces = _inputString.Replace(" ", string.Empty);
            if (inputStringWithoutSpaces.Length % 2 == 0)
            {
                 headOfString = inputStringWithoutSpaces.Substring(0, _inputString.Length / 2);
                 tailOfString = inputStringWithoutSpaces.Substring(_inputString.Length / 2, _inputString.Length - _inputString.Length / 2);
            }
            else
            {
                 headOfString = inputStringWithoutSpaces.Substring(0, _inputString.Length / 2);
                 tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length + 1);
            }
            char[] arr = tailOfString.ToCharArray();
            Array.Reverse(arr);
            tailOfString =  new string(arr);
            if (tailOfString.Equals(headOfString))
                return true;
            else
                return false;
        }

        public string returnReverseString()
        {
            char[] arr = _inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int countsHowManyWordsPerLine()
        {
            while (_inputString.Contains("  ") || _inputString.Contains(".") || _inputString.Contains(","))
                _inputString = _inputString.Replace(",", " ").Replace(".", " ").Replace("  ", " ");
            _inputString = _inputString.Trim();
            string[] textArray = _inputString.Split(new char[] { ' ' });
            return textArray.Length;
        }
    }
}
