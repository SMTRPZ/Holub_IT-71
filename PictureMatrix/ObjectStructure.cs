using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureMatrix
{
    public class ObjectStructure
    {
        private List<Array> PicturesMatrix = new List<Array>() {};
        private List<Element> Pictures = new List<Element>() { };

        public Element Element;


        public List<Array> Create(List<string> Path)
        {
            foreach (var path in Path)
            {
                Element picture = new Element(path);
                Pictures.Add(picture);
                PicturesMatrix.Add(picture.GetColorsMatrix(path));
            }
            return PicturesMatrix;
        }
        
    }
}