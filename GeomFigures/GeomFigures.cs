using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigures
{
    class GeomFigures
    {

       protected double[] _seiten;

        string d;

        public override string ToString()
        {
            foreach (var item in _seiten)
            {

                d += $"Seitenlänge: {item}; ";
                
            }

            return d;


           

    }

        public virtual double Umfang()
        {
            return 0.00;
        }

       public virtual double Fläche()
        {

            return 0.00;

        }

        public GeomFigures(double[] a)
        {
            _seiten = a;
        }


    }
}
