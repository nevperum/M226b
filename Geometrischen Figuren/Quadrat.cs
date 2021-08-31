using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrischen_Figuren
{
    class Quadrat :Rechteck
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Quadrat() 
        {

        }
        //
        public Quadrat(double[] Seiten)
         : base(Seiten)
        {
            Console.WriteLine("--> Quadrat Konstruktor");
        }


        public override double Fläche()
        {

            return seiten[0] * seiten[0];
        }
        public override string ToString()
        {
            return "Quadrat =>" + base.ToString();
        }

        public override double Umfang()
        {
            return 4 * seiten[0];
        }

        
    }
}
