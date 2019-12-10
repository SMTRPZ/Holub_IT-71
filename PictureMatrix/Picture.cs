using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureMatrix
{
    public class Picture : Component
    {
        public Picture(string name): base(name)
        {       
        }
        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }
        public override string AddName(string path)
        {
            return path += name;
        }
        public override void Remove(Component component) 
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }
    }
}