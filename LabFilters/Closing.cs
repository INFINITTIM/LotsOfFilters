using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class Closing : Filters
    {
        private Dilation dilation = new Dilation();
        private Erosion erosion = new Erosion();

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // Сначала выполняем дилатацию, затем эрозию
            Bitmap dilatedImage = dilation.processImage(sourceImage, worker);
            return erosion.processImage(dilatedImage, worker);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            throw new NotImplementedException(".........");
        }
    }
}
