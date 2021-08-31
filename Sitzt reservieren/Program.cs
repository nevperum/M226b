using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzt_reservieren
{
    class Program
    {
        static void Main(string[] args)
        {

            Platz platza = new Platz();
            Bestellung bestellunga = new Bestellung(platza);
            Verkauf verkaufa = new Verkauf(platza);
            Saalplatz saalplatza = new Saalplatz(platza);

        }
    }
}
