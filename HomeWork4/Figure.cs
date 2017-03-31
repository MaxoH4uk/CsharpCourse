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
                _name = value;
            }

            get
            {
                return String.IsNullOrEmpty(_name) ? "Ошибка в названии фигуры" : _name;
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
