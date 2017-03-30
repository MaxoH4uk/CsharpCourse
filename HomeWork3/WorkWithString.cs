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

        public bool IsPolindrom()
        {
            string headOfString;
            string tailOfString;
            string inputStringWithoutSpaces = _inputString.Replace(" ", string.Empty).Replace(".", string.Empty).Replace(",", string.Empty); //убираем пробелы и знаки препинания из строки
            if (inputStringWithoutSpaces.Length % 2 == 0)                                                                                    //делим строку пополам
            {
                headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2);
                tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length);
            }
            else
            {
                headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2);
                tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length + 1);
            }
            tailOfString = ReturnReverseString(tailOfString);            //переворачиваем вторую половину входной строки
            if (tailOfString.ToUpper().Equals(headOfString.ToUpper()))   //сравниваем две части строки
                return true;
            else
                return false;
        }

        public string ReturnReverseString(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int CountsHowManyWordsPerLine()
        {
            string inputStringWithoutSpaces = _inputString;
            while (inputStringWithoutSpaces.Contains("  ") || inputStringWithoutSpaces.Contains(".") || inputStringWithoutSpaces.Contains(",")) //заменяем в строке все двойные пробелы 
                inputStringWithoutSpaces = inputStringWithoutSpaces.Replace(",", " ").Replace(".", " ").Replace("  ", " ");                     //и знаки препинания на одинарные пробелы
            inputStringWithoutSpaces = inputStringWithoutSpaces.Trim();
            string[] textArray = inputStringWithoutSpaces.Split(new char[] { ' ' });
            return textArray.Length;
        }
    }
}
