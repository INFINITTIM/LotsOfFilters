using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Right : MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (x - 100 >= 0)
            {
                return sourceImage.GetPixel(x - 100, y);
            }
            else { return Color.FromArgb(0, 0, 0); }
        }
    }
}
