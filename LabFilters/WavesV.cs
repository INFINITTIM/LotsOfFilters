using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class WavesV : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int _x = x;
            int _y = Clamp(y + (int)(20 * Math.Sin(Math.PI * x / 60)), 0, sourceImage.Height - 1);

            _x = Clamp(_x, 0, sourceImage.Width - 1);
            _y = Clamp(_y, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(_x, _y);
        }
    }
}
