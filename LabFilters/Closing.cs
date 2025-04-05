using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class Closing : MorphologyFilter
    {
        public Closing(bool[,] element = null) : base(element ?? GetStructuringElement(3, "square")) { }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            DilationFilter dilation = new DilationFilter(structuringElement);
            Bitmap dilatedImage = dilation.processImage(sourceImage, worker);

            Erosion erosion = new Erosion(structuringElement);
            return erosion.processImage(dilatedImage, worker);
        }
    }
}
