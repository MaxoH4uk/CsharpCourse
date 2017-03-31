using System;

namespace HomeWork4
{
    class Circle : Figure
    {
        private double _radius;
        public Circle(uint radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * (_radius * _radius);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        new public string GetName
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
    }
}
