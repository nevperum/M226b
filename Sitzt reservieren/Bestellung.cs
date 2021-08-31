using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitzt_reservieren
{
    class Bestellung
    {
        Verkauf Verkauf;
        Platz Platz;

        public Bestellung(Platz platz)
        {
            Platz = platz;
            Platz.kaufen();
            Verkauf.erstelleRechnung();

        }

        public bool IstFrei()
        {
            return true;
        }

        public bool bestätigung()
        {
            return true;
        } 

    }
}
