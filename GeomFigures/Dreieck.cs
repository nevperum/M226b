using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigures
{
    class Dreieck : GeomFigures
    {

        public  override double Umfang()
        {
            return _seiten[0] + _seiten[1] + _seiten[2];
        }

        public override double Fläche()
        {
            return _seiten[0] * _seiten[1] / 2;
        }

        public Dreieck(double[] a)
           : base(a)
        {
            

        }

        public override string Information()
        {
            return base.Information();
        }
    }
}
