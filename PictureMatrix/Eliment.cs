using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO; 

namespace PictureMatrix
{
    public class Element
    {
        public Element(string path)
        { }

        public Array GetColorsMatrix(string path)
        {
            RasterPicture pic = new RasterPicture(path);
            return pic.getPixelPGB();
        }
    }
}