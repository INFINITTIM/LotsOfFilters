using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Brightness : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(
                Clamp(sourceColor.R + 100, 0, 255),
                Clamp(sourceColor.G + 100, 0, 255), 
                Clamp(sourceColor.B + 100,0,255));
            return resultColor;
        }
    }
}
