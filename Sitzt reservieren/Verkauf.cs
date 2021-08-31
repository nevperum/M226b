using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzt_reservieren
{
    class Verkauf
    {

        Saalplatz Saalplatz;

        Platz Platz;
        public Verkauf(Platz platz)
        {
            Platz = platz;
         Saalplatz.buche();

            
        }

     public void erstelleRechnung()
        {
            Console.WriteLine("Rechnung wird erstellt");
        }

    }
}
