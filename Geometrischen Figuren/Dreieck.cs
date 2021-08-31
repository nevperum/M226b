using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrischen_Figuren
{
    class Dreieck : GeomFigur
    {
        /// <summary>
        /// Methode Umfang
        /// </summary>
        /// <returns>Umfang einers Dreieck</returns>
        public override double Umfang()
        {
            return base.Umfang();
        }

        public Dreieck()
        {

        }

        public Dreieck(double[] Seiten)
            : base(Seiten)
        {
            Console.WriteLine("--> Dreieck Konstruktor");
        }

        public override string ToString()
        {
            return "Dreieck =>" + base.ToString();
        }

        public override double Fläche()
        {
            return seiten[0] * seiten[1] / 2;
        }
    }
}
