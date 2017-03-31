using System;

namespace HomeWork4
{
    class Sector : Figure
    {
        private double _radius;
        private double _arcLength;
        public Sector(string name, uint radius, uint arcLength) : base(name)
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
    }
}
