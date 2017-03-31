namespace HomeWork4
{
    class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _h;
        public Triangle(string name, params uint[] hands) : base(name)
        {
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
    }
}
