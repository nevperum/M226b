using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {

            Audio audio = new Audio();
            Video video = new Video();
            Picture picture = new Picture();

            List<IMedia> medias = new List<IMedia>();

            medias.Add(video);
            medias.Add(audio);
            medias.Add(picture);

            foreach (var item in medias)
            {
                Console.WriteLine($"{item.DisplayMedia()}");
                Console.WriteLine($"{item.PlayMedia()}");
                Console.WriteLine($"{item.StopMedia()}");
            }

            Console.ReadLine();

        }
    }
}
