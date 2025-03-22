using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Glass : MatrixFilter
    {
        private Random random = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int _x = x + (int)((random.NextDouble() - 0.5) * 10);
            int _y = y + (int)((random.NextDouble() - 0.5) * 10);

            _x = Clamp(_x, 0, sourceImage.Width - 1);
            _y = Clamp(_y, 0, sourceImage.Height - 1);

            return sourceImage.GetPixel(_x, _y);
        }
    }
}
