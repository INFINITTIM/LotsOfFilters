using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Embossing : MatrixFilter
    {
        public Embossing()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            int counter = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (counter % 2 == 0)
                        kernel[i, j] = 0.0f;
                    if (counter % 2 == 1 && counter < 4)
                        kernel[i, j] = 1.0f;
                    if (counter % 2 == 1 && counter > 4)
                        kernel[i, j] = -1.0f;
                    counter++;
                }
            }
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(
                Clamp((int)resultR + 100, 0, 255),
                Clamp((int)resultG + 100, 0, 255),
                Clamp((int)resultB + 100, 0, 255));
        }
    }
}
