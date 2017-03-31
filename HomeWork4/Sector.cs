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
                _name = value;
            }

            get
            {
                return String.IsNullOrEmpty(_name) ? "Ошибка в названии фигуры" : _name;
            }
        }
    }
}
