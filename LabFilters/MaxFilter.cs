using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class MaxFilter : Filters
    {
        private int radius;

        public MaxFilter(int radius = 1)
        {
            this.radius = radius;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int maxR = 0, maxG = 0, maxB = 0;

            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    int newX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int newY = Clamp(y + j, 0, sourceImage.Height - 1);

                    Color color = sourceImage.GetPixel(newX, newY);

                    maxR = Math.Max(maxR, color.R);
                    maxG = Math.Max(maxG, color.G);
                    maxB = Math.Max(maxB, color.B);
                }
            }

            return Color.FromArgb(maxR, maxG, maxB);
        }
    }
}
