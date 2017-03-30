using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _h;
        public Triangle(string name, params uint[] hands)
        {
            _name = name;
            _a = hands[0];
            _b = hands[1];
            _c = hands[2];
            _h = hands[3];
        }

        public override double GetArea()
        {
            return _a * _h / 2;
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }

        public override string GetName()
        {
            return _name;
        }
    }
}
