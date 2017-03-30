using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Figure
    {
        protected string _name;
        public Figure()
        {
            _name = "Фигура";
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
            return "Это родительский класс Фигура";
        }
    }
}
