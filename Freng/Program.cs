using System;
using System.Drawing;
using System.Linq;

namespace Freng
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args.ElementAtOrDefault(0) ?? "C:\\Users\\mo\\Downloads\\flower (1).jpg";
            var image = new Bitmap(file);
            Canvas.Draw(image);
        }
    }
}