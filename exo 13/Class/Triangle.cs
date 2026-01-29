using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_13.Interface;

namespace exo_13.Class
{
    internal class Triangle :Figure , IDeplacable
    {
        private int _base;
        private int _height;

        public int Base { get { return _base; } set { _base = value; } }
        public int Height { get { return _height; } set { _height = value; } }

        public Triangle(int Base, int Height,Point origine) : base(origine)
        { 
            _base = Base;
            _height = Height;
        }
        public void Deplacer(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public override string ToString()
        {
            return
                $"Le Triangle de {Height} hauteur et {Base} base " +
                base.ToString(); ;
        }
    }
}
