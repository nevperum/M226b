using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzt_reservieren
{
    class Saalplatz
    {
        Bestellung bestellung;

        Platz Platz;
        public Saalplatz(Platz platz)
        {
            Platz = platz;

            bestellung.IstFrei();

            this.reservieren();
        }

        public void reservieren()
        {
            Console.WriteLine($"Platz ist reserviert");
        }

        public void buche()
        {
            Console.WriteLine("Wird im System eingetragen");
        }
    }
}
