using System;

namespace HomeWork4
{
    class Sector : Figure
    {
        private double _radius;
        private double _arcLength;
        public Sector(uint radius, uint arcLength)
        {
            _radius = radius;
            _arcLength = arcLength;
        }

        public override double GetArea()
        {
            return _arcLength * _radius / 2;
        }

        public override double GetPerimeter()
        {
            return _arcLength + 2 * _radius;
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
