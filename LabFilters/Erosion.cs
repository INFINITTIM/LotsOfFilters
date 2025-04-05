using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class Erosion : MorphologyFilter
    {
        public Erosion(bool[,] element = null) : base(element ?? GetStructuringElement(3, "square")) { }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int minR = 255, minG = 255, minB = 255;

            for (int i = -elementSize; i <= elementSize; i++)
            {
                for (int j = -elementSize; j <= elementSize; j++)
                {
                    int newX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int newY = Clamp(y + j, 0, sourceImage.Height - 1);

                    if (structuringElement[i + elementSize, j + elementSize])
                    {
                        Color color = sourceImage.GetPixel(newX, newY);
                        minR = Math.Min(minR, color.R);
                        minG = Math.Min(minG, color.G);
                        minB = Math.Min(minB, color.B);
                    }
                }
            }
            return Color.FromArgb(minR, minG, minB);
        }
    }
}
