namespace HomeWork4
{
    class Figure
    {
        protected string _name;
        public Figure(string name)
        {
            _name = name;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }

        public virtual string GetName()
        {
            return _name;
        }
    }
}
