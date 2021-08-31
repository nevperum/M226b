using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions.Circle
{
    /// <summary>
    /// Kreisklasse
    /// </summary>
    /// <remarks>
    /// Übung Kreisklasse vom Buch
    /// </remarks>
    public class Circle
    {
        /// <summary>
        /// X Koordinate des Kreises mit Autoprop
        /// </summary>
        public double XCoordinate { get; set; }

        /// <summary>
        /// Y Koordinate des Kreises
        /// </summary>
        public double YCoordinate { get; set; }

        /// <summary>
        /// Radius des Kreises mit Fullprop
        /// </summary>
        /// <exception cref="Exception"
  
        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                    _Radius = value;
                else
                    throw new Exception($"Radius inkorrekt: {value}");
            }
        }

        /// <summary>
        /// Leerer Kreis
        /// </summary>
        public Circle()
        {
            Radius = 0;
            XCoordinate = 0;
            YCoordinate = 0;
        }

        /// <summary>
        /// Kreis mit Radius
        /// </summary>
        /// <param name="rad">
        /// Radius
        /// </param>
        public Circle(int rad)
            : this()
        {
            Radius = rad;
        }



        /// <summary>
        /// Kreis mit Koordinate und Radius
        /// </summary>
        /// <param name="x">
        /// X Koordinate
        /// </param>
        /// <param name="y">
        /// Y Koordinate
        /// </param>
        /// <param name="rad">
        /// Radius
        /// </param>
        public Circle(double x, double y, int rad)
            : this(rad)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        /// <summary>
        /// Fläche wird berechnet
        /// </summary>
        /// <returns>
        /// Fläche
        /// </returns>
        public double getArea()
        {
            double Area = Math.Pow(Radius, 2) * Math.PI;
            return Area;
        }

        /// <summary>
        /// Umfang berechnen
        /// </summary>
        /// <returns>
        /// Umfang
        /// </returns>
        public double getCircumference()
        {
            return Radius * 2 * Math.PI;
        }

        /// <summary>
        /// Bewegen
        /// </summary>
        /// <param name="dx">
        /// Delta X
        /// </param>
        /// <param name="dy">
        /// Delta Y
        /// </param>
        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        /// <summary>
        /// Bewegen mit Radius
        /// </summary>
        /// <param name="dx">
        /// Delta X
        /// </param>
        /// <param name="dy">
        /// Delta Y
        /// </param>
        /// <param name="drad">
        /// Delta Radius
        /// </param>
        public void Move(double dx, double dy, int drad)
        {
            Move(dx, dy);
            Radius += drad;
        }



    }
}
