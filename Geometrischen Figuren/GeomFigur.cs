using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrischen_Figuren
{
    class GeomFigur : IDrow
    {
        /// <summary>
        /// Eigenschaft
        /// </summary>
        protected double[] seiten = new double[3];

        public string Color { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public GeomFigur()
        {

        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="Seiten"></param>
        public GeomFigur(double[] Seiten)
        {

            Console.WriteLine("--> GeomFigur Konstruktor");
            seiten = Seiten;
        }
        /// <summary>
        /// Methode Inforamtionen
        /// </summary>
        /// <returns>alle Seiten</returns>
       public ove   rride string ToString()
        {
            string result = "Seitenlängen: ";
            foreach(double d in seiten)
            {
                result += $"{d} \t ";
            }
            return result;
        }

        
        /// <summary>
        /// Methode Umfang
        /// </summary>
        /// <returns>Umfang des Geo</returns>
        public virtual double Umfang()

        {
            double U = 0.00;

            foreach (var Seiten in seiten)
            {
                 U += Seiten;
           
            }
            return U;
        }

        public virtual double Fläche()
        {

            return 0.0;
           
        }

        public void Draw()
        {
            Console.WriteLine($" Draw Farbe= {Color}");
        }
    }
}
