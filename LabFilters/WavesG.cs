using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class WavesG : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int _x = x + (int)(20 * Math.Sin(2 * Math.PI * x / 30));
            int _y = y;

            _x = Clamp(_x, 0, sourceImage.Width - 1);
            _y = Clamp(_y, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(_x, _y);
        }
    }
}
