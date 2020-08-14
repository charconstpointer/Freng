using System.Drawing;
using Colorful;

namespace Freng
{
    public class Canvas
    {
        private readonly int _height;
        private readonly int _width;
        private readonly string _display;

        public Canvas(int height, int width, string display = "██")
        {
            _height = height;
            _width = width;
            _display = display;
        }

        // public void Display()
        // {
        //     Console.Clear();
        //     var resolution = _height * _width;
        //     var row = 0;
        //     for (var i = 0; i < resolution; i++)
        //     {
        //         if (i % _width == 0)
        //         {
        //             if (i > 0)
        //             {
        //                 row++;
        //             }
        //         }
        //
        //         Console.SetCursorPosition(i % _width * 2, row);
        //         Console.WriteLine($"{_display}");
        //     }
        // }

        public static void Draw(Bitmap image)
        {
            var w = image.Width;
            var h = image.Height;
            var canvas = new Canvas(w, h);
            canvas.DrawImage(image);
        }

        private void DrawImage(Bitmap image)
        {
            Console.Clear();
            var resolution = image.Height * image.Width;
            var row = 0;
            for (var i = 0; i < resolution; i++)
            {
                if (i % _width == 0)
                {
                    if (i > 0)
                    {
                        row++;
                    }
                }

                Console.SetCursorPosition(i % image.Width * 2, row);
                var color = image.GetPixel(i % image.Width, row);
                Console.Write($"{_display}", color);
            }
        }
    }
}