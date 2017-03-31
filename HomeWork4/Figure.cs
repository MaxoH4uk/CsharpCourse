using System;

namespace HomeWork4
{
    class Figure
    {
        protected string _name;
        protected string GetName
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value;
                else
                    Console.WriteLine("Ошибка в названии фигуры");
            }

            get
            {
                return _name;
            }
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
