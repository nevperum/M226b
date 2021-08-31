using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {

            GiroKonto girokonto1 = new GiroKonto()
            {
                _nuber = 1000,
                _limit = 200.0,
                _name = "Giro-1",
                _dispValue = -1000.0
            };



            girokonto1.PayIn(1000);

            girokonto1.PayOut(500);





            //int a = 0;

            //int eingabe;




            //            do
            //            {



            //                try
            //            {








            //                do
            //                {

            //                    Console.WriteLine($"Geben Sie 1, um Geld auf Ihr Konto zu legen.\nGeben Sie 2, um " +
            //                        $"Geld aus Ihr Konto zu zunehmen. \nGeben Sie 0, um die Application zu beenden.");

            //                    eingabe = Convert.ToInt32(Console.ReadLine());



            //                    if (eingabe == 1)
            //                    {
            //                        Console.WriteLine("Geben Sie den Betrag den sie Einzahlen wollen");
            //                        eingabe = Convert.ToInt32(Console.ReadLine());
            //                        konto.Kontostand += eingabe;
            //                        Console.WriteLine($"Sie haben auf Ihr Konto :{konto.Kontostand} Fr.");


            //                    }

            //                    else if (eingabe == 2)
            //                    {

            //                        Console.WriteLine("Geben Sie den Betrag den sie Auszahlen wollen");
            //                        eingabe = Convert.ToInt32(Console.ReadLine());
            //                        konto.Kontostand -= eingabe;
            //                        Console.WriteLine($"Sie haben auf Ihr Konto :{konto.Kontostand} Fr.");



            //                    }

            //                    else
            //                    {
            //                      throw new Exception("Thats the Wrong Number");
            //                    }

            //                } while (eingabe != 0);
            //            }

            //            catch (Exception ex)
            //            {

            //                Console.WriteLine($" \a Fehler. {ex.Message}");


            //            }






            //            } while (a != 0);

            //            Console.ReadLine();
        }

    }
}
