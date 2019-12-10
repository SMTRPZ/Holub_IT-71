using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureMatrix
{
    public abstract class Component
    {
        protected string name { get; set; }
        public Component(string name)
        {
            this.name = name;
        }
        public abstract string AddName(string path);
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);

    }
}