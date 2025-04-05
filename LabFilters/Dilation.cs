using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class DilationFilter : MorphologyFilter
    {
        public DilationFilter(bool[,] element = null) : base(element ?? GetStructuringElement(3, "square")) { }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int maxR = 0, maxG = 0, maxB = 0;

            for (int i = -elementSize; i <= elementSize; i++)
            {
                for (int j = -elementSize; j <= elementSize; j++)
                {
                    int newX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int newY = Clamp(y + j, 0, sourceImage.Height - 1);

                    if (structuringElement[i + elementSize, j + elementSize])
                    {
                        Color color = sourceImage.GetPixel(newX, newY);
                        maxR = Math.Max(maxR, color.R);
                        maxG = Math.Max(maxG, color.G);
                        maxB = Math.Max(maxB, color.B);
                    }
                }
            }
            return Color.FromArgb(maxR, maxG, maxB);
        }
    }
}
