using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzt_reservieren
{
    class Platz
    {
        Bestellung Bestellung;


        public Platz()
        {
            Bestellung.bestätigung();
        }
        public void kaufen()
        {
            


            Console.WriteLine("Platz wird gekauft");
        }

    }
}
