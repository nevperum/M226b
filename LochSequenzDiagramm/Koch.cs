using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LochSequenzDiagramm
{
    class Koch
    {
        private Herd herd;
        public Koch(Herd Herd)
        {

            herd = Herd;
            herd.Einschalten();

            herd.Ausschalten();
        }
    }
}
