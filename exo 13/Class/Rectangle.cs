using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_13.Interface;

namespace exo_13.Class
{
    internal class Rectangle : Figure ,IDeplacable
    {
        private int _longueur;
        private int _largeur;

        public int Longueur { get { return _longueur; } set { _longueur = value; } }
        public int Largeur { get { return _largeur; } set { _largeur = value; } }

        public Rectangle(int longueur, int largeur,Point origine) : base(origine)
        {

            _longueur = longueur;
            _largeur = largeur;
        }
        public void Deplacer(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public override string ToString()
        {
            return 
                $"Le Rectangle de {Longueur} longueur et {Largeur} largeur" +
                base.ToString(); ;
        }
    }
}
