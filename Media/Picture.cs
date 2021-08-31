using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Picture : IMedia
    {
      

        string IMedia.DisplayMedia()
        {
            return $"{this.GetType().Name}: Picture wird angezeigt";
        }

        string IMedia.PlayMedia()
        {
            return $"{this.GetType().Name}: Picture gestartet";
        }

        string IMedia.StopMedia()
        {
            return $"{this.GetType().Name}: Picture wird ausgeblendet";
        }
    }
}
