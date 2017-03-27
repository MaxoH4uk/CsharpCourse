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
            if (returnReverseString().Equals(_inputString))
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
