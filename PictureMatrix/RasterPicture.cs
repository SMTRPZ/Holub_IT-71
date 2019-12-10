using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;


namespace PictureMatrix
{
    public class RasterPicture : Element
    {
        private Bitmap image;
        private Color[,] pixels;
        public RasterPicture(string path) : base(path)
        {
            if (path != "")
            {
                image = new Bitmap(path, true);
                pixels = new Color[image.Width, image.Height];
            }
        }

        public Array getPixelPGB()
        {
            if (image == null)
            {
                Console.WriteLine("Picture is not found");
                Console.ReadKey();
            }
            else
            {
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        Color color = image.GetPixel(x, y);
                        pixels[x, y] = color;
                        //Console.WriteLine(color);
                    }
                }
            }
            //Console.ReadKey();
            return pixels;
        }
    }
}
