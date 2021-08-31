using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Video : IMedia
    {
 

        string IMedia.DisplayMedia()
        {
            return $"{this.GetType().Name}: Video wird angezeigt";
        }

        string IMedia.PlayMedia()
        {
            return $"{this.GetType().Name}: Video gestartet";
        }

        string IMedia.StopMedia()
        {
            return $"{this.GetType().Name}: Video gestoppt";
        }
    }
}
