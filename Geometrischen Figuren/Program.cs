using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrischen_Figuren;

namespace Geometrischen_Figuren
{
    class Program 
    {
        static void Main(string[] args)
        {



            List<GeomFigur> geomFigurs = new List<GeomFigur>();
            

            Rechteck rechteck1 = new Rechteck(new double[] {10.0, 20.0 }) ;
            //Console.WriteLine($" Rechteckfläche= {rechteck1.Fläche()}");
            //Console.WriteLine($"{rechteck1.ToString()}");
            geomFigurs.Add(rechteck1);

            Dreieck dreieck1 = new Dreieck(new double[] { 10.0, 20.0, 30.0 });
            //Console.WriteLine($" Rechteckfläche= {dreieck1.Umfang()}");
            //Console.WriteLine($"{dreieck1.ToString()}");
            geomFigurs.Add(dreieck1);

            Quadrat quadrat1 = new Quadrat(new double[] { 10.0});
            //Console.WriteLine($" Rechteckfläche= {quadrat1.QuadratFläche()}");
            //Console.WriteLine($"{quadrat1.ToString()}");
            geomFigurs.Add(quadrat1);

            
            

            foreach (var geoFigursList in geomFigurs)
            {
                Console.WriteLine(geoFigursList.ToString());
                Console.WriteLine($"Umfang = {geoFigursList.Umfang()}");
                Console.WriteLine($"Fläche = {geoFigursList.Fläche()}");
                Console.ReadLine();
            }


            Console.ReadLine();










        }
    }
}