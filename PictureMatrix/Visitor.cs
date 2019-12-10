using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace PictureMatrix
{
    public class Visitor
    {
        string writePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.txt";
        public float[,] GetBrightnessMatrix(Color[,] matrix)
        {
            float[,] brightness = new float[matrix.GetLength(0), matrix.GetLength(1)];
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        Color color = matrix[x, y];
                        brightness[x, y] = color.GetBrightness();
                    
                        sw.Write(color.GetBrightness() + ", ");
                        //Console.Write(brightness[x, y]);
                    }
                    sw.Write("\n");
                }
            }
            
            //Console.ReadKey();
            return brightness;
        }
    }
}