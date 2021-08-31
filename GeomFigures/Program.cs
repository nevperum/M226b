using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GeomFigures> geomFigures = new List<GeomFigures>();



            Rechteck rechteck = new Rechteck(new double[] { 10.0, 20.0 });

            Quadrat quadrat = new Quadrat(new double[] { 10.0 });

            Dreieck dreieck = new Dreieck(new double[] { 10.0, 20.0, 30.0 });

            geomFigures.Add(rechteck);

            geomFigures.Add(quadrat);

            geomFigures.Add(dreieck);

            foreach (var item in geomFigures)
            {
                Console.WriteLine($"{item.Information()}");

            }

            Console.WriteLine($" {dreieck.ToString()}{dreieck.Information()}\nUmfang ={dreieck.Umfang()}\nFläche ={dreieck.Fläche()}");

            Console.ReadLine();



        }
    }
}
