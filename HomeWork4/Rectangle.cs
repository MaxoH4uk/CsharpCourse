using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Rectangle : Figure
    {
        private double _a;
        private double _b;
        public Rectangle(string name, params uint[] hands)
        {
            _name = name;
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

        public override string GetName()
        {
            return _name;
        }
    }
}
