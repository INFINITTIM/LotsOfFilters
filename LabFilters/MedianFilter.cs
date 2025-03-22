using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class MedianFilter : MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> AllR = new List<int>();
            List<int> AllG = new List<int>();
            List<int> AllB = new List<int>();

            int radiusX = 1;
            int radiusY = 1;

            for (int k = -radiusX; k <= radiusX; k++)
            {
                for (int l = -radiusY; l <= radiusY; l++)
                {
                    int xX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int yY = Clamp(y + l, 0, sourceImage.Height - 1);

                    Color color = sourceImage.GetPixel(xX, yY);

                    AllR.Add(color.R);
                    AllG.Add(color.G);
                    AllB.Add(color.B);
                }
            }

            AllR.Sort();
            AllG.Sort();
            AllB.Sort();

            // Получаем медианные значения
            int medianR = AllR[AllR.Count / 2];
            int medianG = AllG[AllG.Count / 2];
            int medianB = AllB[AllB.Count / 2];

            return Color.FromArgb(medianR, medianG, medianB);
        }
    }
}

