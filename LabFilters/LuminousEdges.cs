using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class LuminousEdges : MatrixFilter
    {
        private MedianFilter medianFilter;
        private SobelFilter sobelFilter;
        private MaxFilter maximumFilter;

        public LuminousEdges(int medianRadius = 1)
        {
            medianFilter = new MedianFilter(medianRadius);
            sobelFilter = new SobelFilter();
            maximumFilter = new MaxFilter();
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {

            Bitmap medianImage = medianFilter.processImage(sourceImage, worker);
            Bitmap edgesImage = sobelFilter.processImage(medianImage, worker);
            Bitmap glowingEdgesImage = maximumFilter.processImage(edgesImage, worker);

            return glowingEdgesImage;
        }
    }
}
