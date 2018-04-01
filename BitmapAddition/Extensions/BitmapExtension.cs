using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BitmapAddition.Extensions
{
    public static class BitmapExtension
    {
        public static (int[] rValues, int[] gValues, int[] bValues) GetRgbValues(this Bitmap bitmap)
        {
            List<int> rValues = new List<int>();
            List<int> gValues = new List<int>();
            List<int> bValues = new List<int>();

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    Color pixel = bitmap.GetPixel(j, i);

                    rValues.Add(pixel.R);
                    gValues.Add(pixel.G);
                    bValues.Add(pixel.B);
                }
            }

            return (rValues.ToArray(), gValues.ToArray(), bValues.ToArray());
        }  

        public static void SetPixels(this Bitmap bitmap, int[] rValues, int[] gValues, int[] bValues)
        {
            Queue<int> rResultQueue = new Queue<int>(rValues);
            Queue<int> gResultQueue = new Queue<int>(gValues);
            Queue<int> bResultQueue = new Queue<int>(bValues);

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    int r = rResultQueue.Dequeue();
                    int g = gResultQueue.Dequeue();
                    int b = bResultQueue.Dequeue();

                    Color pixel = Color.FromArgb(r, g, b);
                    bitmap.SetPixel(j, i, pixel);
                }
            }
        }
    }
}
