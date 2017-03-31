using System;

namespace HomeWork4
{
    class Rectangle : Figure
    {
        private double _a;
        private double _b;
        public Rectangle(string name, params uint[] hands) : base(name)
        {
            _a = hands[0];
            _b = hands[1];
        }

        public override double GetArea()
        {
            return _a * _b;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }        
    }
}
