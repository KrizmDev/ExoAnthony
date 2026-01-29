using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_13.Class
{
    internal abstract class Figure : Point
    {
        protected Point origine;

        public Point Origine
        {
            get { return origine; }
            protected set { origine = value; }
        }

        protected Figure(Point origine) : base(origine.X, origine.Y)
        {
            this.origine = origine;
        }

        public virtual void Deplacer(double dx, double dy)
        {
            origine.Deplacer(dx, dy);
        }
    }
}
