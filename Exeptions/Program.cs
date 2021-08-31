using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Bitte eine Zahl eingeben  ");
                Console.Write("Ihre Zahl: ");
                int input = Convert.ToInt32(Console.ReadLine());

                int zahl1 = 100 / input;

                Console.WriteLine($"Die Zahl ist = {input}, Zahl1 = {zahl1}");


            }
            catch (OverflowException ex)
            {
                Console.WriteLine($" Overflow Fehler. {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Fehler. {ex.Message}");
            }
            catch (Exception ex)
            {


                Console.WriteLine($" \a Fehler. {ex.Message}");
               
            }

            Console.ReadKey();

        }
    }
}
