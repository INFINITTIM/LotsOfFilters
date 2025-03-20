using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double Intensity = 0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B;
            Color resultColor = Color.FromArgb((int)Intensity,
                (int)Intensity, (int)Intensity);
            return resultColor;
        }
    }
}
