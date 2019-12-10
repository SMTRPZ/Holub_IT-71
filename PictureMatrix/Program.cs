using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace PictureMatrix
{
    public class Program
    {
        public static void createMatrix(string path)
        {
            List<string> Path = new List<string>() { path };

            ObjectStructure images = new ObjectStructure();
            List<Array> matrixList = images.Create(Path);

            foreach (Color[,] item in matrixList)
            {
                if (item != null)
                {
                    Visitor visitor = new Visitor();
                    float[,] matrix = visitor.GetBrightnessMatrix(item);
                }
                else
                {
                    Console.WriteLine("Provide a program with a path");
                    Console.ReadKey();
                }
            }
        }

        public ObjectStructure ObjectStructure
        {
            get => default;
            set
            {
            }
        }

        public static string createPath()
        {
            Component root = new Folder(@"\root");
            Component branch = new Folder(@"\branch");
            Component leaf = new Picture(@"\linux.jpeg");

            root.Add(branch);
            branch.Add(leaf);

            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + root.AddName("");
        }

        public Visitor Visitor
        {
            get => default;
            set
            {
            }
        }

        public Component Component
        {
            get => default;
            set
            {
            }
        }

        public IParameterCout IParameterCout
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {


            string path = ""; //укажи путь к картинке

            Program.createMatrix(path);

            Console.WriteLine(path);
            Console.ReadKey();
        }
    }
}
