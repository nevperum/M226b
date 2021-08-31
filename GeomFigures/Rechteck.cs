using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigures
{
    class Rechteck : GeomFigures
    {


        public override double Umfang()
        {
            return _seiten[0] + _seiten[1] * 2;
        }

        public override double Fläche()
        {
            return _seiten[0] * _seiten[1];
        }

        public Rechteck(double[] a)
            : base(a)
        {
            
        }

    }


}
