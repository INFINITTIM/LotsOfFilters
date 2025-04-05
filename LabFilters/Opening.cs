using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Opening : Filters
    {
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Erosion erosionFilter = new Erosion();
            Bitmap erodedImage = erosionFilter.processImage(sourceImage, worker);
            Dilation dilationFilter = new Dilation();
            return dilationFilter.processImage(erodedImage, worker);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException(".........");
        }
    }
}
