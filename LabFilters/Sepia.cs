using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Sepia : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            double Intensity = 0.36 * sourceColor.R + 0.53 * sourceColor.G + 0.11 * sourceColor.B;
            int r = Clamp((int)(Intensity + 2*25), 0, 255);
            int g = Clamp((int)(Intensity + 0.5*25), 0, 255);
            int b = Clamp((int)(Intensity - 1*25), 0, 255);
            Color resultColor = Color.FromArgb(r, g, b);
            return resultColor;
        }
    }
}
