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
            string inputStringWithoutSpaces = removeSpacesFromString(_inputString).Replace(" ", string.Empty); //убираем пробелы и знаки препинания из строки
            if (inputStringWithoutSpaces.Length % 2 == 0)                                                      //делим строку пополам
            {
                headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2); 
                tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length);
            }
            else
            {
                headOfString = inputStringWithoutSpaces.Substring(0, inputStringWithoutSpaces.Length / 2);
                tailOfString = inputStringWithoutSpaces.Remove(0, headOfString.Length + 1);
            }
            tailOfString = returnReverseString(tailOfString);            //переворачиваем вторую половину входной строки
            if (tailOfString.ToUpper().Equals(headOfString.ToUpper()))   //сравниваем две части строки
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
            string[] textArray = inputStringWithoutSpaces.Split(new char[] { ' ' });
            return textArray.Length;
        }

        public string removeSpacesFromString(string inputString)
        {
            while (inputString.Contains("  ") || inputString.Contains(".") || inputString.Contains(",")) //заменяем в строке все двойные пробелы 
                inputString = inputString.Replace(",", " ").Replace(".", " ").Replace("  ", " ");        //и знаки препинания на одинарные пробелы
            inputString = inputString.Trim();                                                            //убираем пробелы из начала и конца строки
            return inputString;
        }
    }
}
