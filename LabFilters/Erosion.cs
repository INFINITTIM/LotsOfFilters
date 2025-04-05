using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Erosion : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color minColor = Color.White;
            int kernelSize = 1; // Размер ядра

            for (int i = -kernelSize; i <= kernelSize; i++)
            {
                for (int j = -kernelSize; j <= kernelSize; j++)
                {
                    int newX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int newY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(newX, newY);

                    // Выбираем минимальное значение цвета
                    if (neighborColor.R < minColor.R || neighborColor.G < minColor.G || neighborColor.B < minColor.B)
                        minColor = neighborColor;
                }
            }
            return minColor;
        }
    }
}
