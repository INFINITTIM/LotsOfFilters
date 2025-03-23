using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class PerfectReflector : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int _x = sourceImage.Width - 1 - x;
            int _y = y;

            return sourceImage.GetPixel(_x, _y);
        }
    }
}
