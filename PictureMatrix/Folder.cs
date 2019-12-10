using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureMatrix
{
    public class Folder : Component
    {
        List<Component> nodes = new List<Component>() { };
        public Folder(string name) : base(name)
        {   
        }

        public override string AddName(string path)
        {
            path += name;
            foreach (Component component in nodes)
            {
                path = component.AddName(path);
            }
            return path;
        }
        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }
    }
}