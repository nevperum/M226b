using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrischen_Figuren 
{
    class Rechteck : GeomFigur
    {

      

        ///
        /// <summary>
        /// default ctor
        /// </summary>
        public Rechteck()
        {

        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="Seiten"></param>
        public Rechteck(double[] Seiten)
           : base(Seiten)
        {
            Console.WriteLine("--> Rechteck Konstruktor");
        }

        public override string ToString()
        {
            return "Rechteck =>" + base.ToString();    
        }

        public override double Umfang()
        {
            return 2 * (seiten[0] + seiten[1]);
            
        }
        public override double Fläche()
        {
            return seiten[0] * seiten[1];
        }


    }
}
