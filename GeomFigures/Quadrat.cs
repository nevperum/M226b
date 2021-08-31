using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigures
{
    class Quadrat : Rechteck
    {

        public override double Umfang()
        {
            return _seiten[0] * 4;
        }

        public override double Fläche()
        {
            return _seiten[0] * _seiten[0];
        }

        public Quadrat(double[] a)
            : base(a)
        {

        }

       

    }
}
