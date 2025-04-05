using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class Opening : MorphologyFilter
    {
        public Opening(bool[,] element = null) : base(element ?? GetStructuringElement(3, "square")) { }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {

            Erosion erosion = new Erosion(structuringElement);
            Bitmap erodedImage = erosion.processImage(sourceImage, worker);

            DilationFilter dilation = new DilationFilter(structuringElement);
            return dilation.processImage(erodedImage, worker);
        }
    }
}
