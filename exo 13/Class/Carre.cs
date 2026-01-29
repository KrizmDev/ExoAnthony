using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_13.Interface;

namespace exo_13.Class
{
    internal class Carre : Figure , IDeplacable
    {
        private int _coter;

        public int Coter { get { return _coter; } set { _coter = value; } }

        public Carre(int coter,Point origine) : base(origine)
        {
            _coter = coter;
        }
        public void Deplacer(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public override string ToString()
        {
            return 
                $"Le Triangle de {Coter} coter " +
                base.ToString() ;
        }
    }
}
