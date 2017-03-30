using System;

namespace HomeWork4
{
    class Circle : Figure
    {
        private double _radius;
        public Circle(string name, uint radius)
        {
            _name = name;
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

        public override string GetName()
        {
            return _name;
        }
    }
}
