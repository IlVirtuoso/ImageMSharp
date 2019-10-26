using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageMSharp.Libs
{
    public static class ImageMatrix
    {
        

    public static Color[,] toMatrix(this Image image)
    {
        Color[,] matrix = new Color[image.Width, image.Height];
        Bitmap image_bit = (Bitmap)image;
        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                matrix[x, y] = image_bit.GetPixel(x, y);
            }
        }
        return matrix;
    }

    public static Image toImage(this Color[,] matrix)
    {
        Bitmap newimage = new Bitmap(matrix.GetLength(0), matrix.GetLength(1));
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                newimage.SetPixel(x, y, matrix[x, y]);
            }
        }
        return newimage;
    }
}
}
