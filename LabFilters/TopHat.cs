using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class TopHat : MorphologyFilter
    {
        private int scaleFactor = 3; //усиление контраста

        public TopHat(bool[,] element = null) : base(element ?? GetStructuringElement(3, "square")) { }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {

            Opening opening = new Opening(structuringElement);
            Bitmap openedImage = opening.processImage(sourceImage, worker);

            Bitmap result = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color orig = sourceImage.GetPixel(x, y);
                    Color open = openedImage.GetPixel(x, y);

                    int r = Clamp((orig.R - open.R) * scaleFactor, 0, 255);
                    int g = Clamp((orig.G - open.G) * scaleFactor, 0, 255);
                    int b = Clamp((orig.B - open.B) * scaleFactor, 0, 255);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }
    }
}
